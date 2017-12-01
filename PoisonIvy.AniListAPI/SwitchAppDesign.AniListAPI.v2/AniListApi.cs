using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Fields;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.PrebuiltQueries;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;

namespace SwitchAppDesign.AniListAPI.v2
{
    /// <summary>
    /// Exposes all available queries to the AniList API. Includes pre-built queries as well as more advanced custom built queries.
    /// </summary>
    public class AniListApi
    {
        private static AniListProxy _proxy;
        private readonly JsonSerializerSettings _serializerSettings;

        public AniListApi()
        {
            _proxy = new AniListProxy();
            _serializerSettings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }

        /// <summary>
        /// Fetches a basic instance of media model of type anime.
        /// </summary>
        public async Task<Media> GetBasicAnime(int anilistMediaId)
        {
            try
            {
                var query = new PreBuiltMediaQueries().BasicAnimeMediaQuery(anilistMediaId);

                var rawQuery = GetBody(query);

                var result = await _proxy.GenericPostAsync<Media>(rawQuery);

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private HttpContent GetBody(GraphQuery query)
        {
            return new StringContent(JsonConvert.SerializeObject(query, _serializerSettings), Encoding.UTF8, "application/json");
        }
    }

    //Console.WriteLine("==========================================");
    //Console.WriteLine("Variables");
    //Console.WriteLine("==========================================");
    //Console.WriteLine();
    //Console.WriteLine(val.Variables);
    //Console.WriteLine();
    //Console.WriteLine();
    //Console.WriteLine("==========================================");
    //Console.WriteLine("Query");
    //Console.WriteLine("==========================================");
    //Console.WriteLine();
    //Console.WriteLine(val.Query);
}
