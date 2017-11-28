using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using SwitchAppDesign.AniListAPI.v2.Graph.Fields;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.PrebuiltQueries;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2
{
    /// <summary>
    /// Exposes all available queries to the AniList API. Includes pre-built queries as well as more advanced custom built queries.
    /// </summary>
    public class AniListApi
    {
        /// <summary>
        /// Fetches a basic instance of media model of type anime.
        /// </summary>
        public void GetBasicAnime(int anilistMediaId)
        {
            var val = new PreBuiltMediaQueries().FullAnimeQuery(anilistMediaId);

            Console.WriteLine("==========================================");
            Console.WriteLine("Variables");
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine(val.Variables);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Query");
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine(val.Query);
        }
    }
}
