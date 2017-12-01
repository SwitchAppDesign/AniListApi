using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Responses;

namespace SwitchAppDesign.AniListAPI.v2.Common
{
    internal class AniListProxy
    {
        private readonly HttpClient _client;
        private const string AniListBaseUrl = "https://graphql.anilist.co";

        public AniListProxy()
        {
            _client = new HttpClient();
        }

        public async Task<T> GenericPostAsync<T>(HttpContent content, AniListQueryType queryType, bool isVerifyInstance = false)
            where T : class
        {
            var response = await _client.PostAsync(AniListBaseUrl, content);

            //This check is due to the token timeout that may occur while the app is running.
            //if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            //{
            //    if (!isVerifyInstance)
            //    {
            //        await LoginAsync();
            //        return await GenericPostAsync<T>(url, content, true);
            //    }
            //    else
            //    {
            //        throw new Exception("Unauthorized access. Please validate the login details.");
            //    }
            //}

            response.EnsureSuccessStatusCode();

            // TODO needs to be upgraded to factor in Query type and multiple values
            var value = await response.Content.ReadAsStringAsync();

            var jsonObj = JObject.Parse(value);

            if (!jsonObj.HasValues)
                return null;

            var data = jsonObj.GetValue("data");

            return !data.HasValues ? null : data.Values().First().ToObject<T>();
        }

        public async Task<T> GenericGetAsync<T>(string url, bool isVerifyInstance = false)
            where T : class
        {
            var response = await _client.GetAsync(url);

            //if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            //{
            //    if (!isVerifyInstance)
            //    {
            //        await LoginAsync();
            //        return await GenericGetAsync<T>(url, true);
            //    }
            //    else
            //    {
            //        throw new Exception("Unauthorized access. Please validate the login details.");
            //    }
            //}

            response.EnsureSuccessStatusCode();

            var value = await response.Content.ReadAsStringAsync();

            if (typeof(T) == typeof(string))
            {
                return value as T;
            }

            var responseObj = JsonConvert.DeserializeObject<T>(value);

            return responseObj;
        }
    }
}
