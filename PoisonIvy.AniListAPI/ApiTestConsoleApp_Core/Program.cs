using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ApiTestConsoleApp_Core.Tests;
using Newtonsoft.Json;
using SwitchAppDesign.AniListAPI.v2;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders;

namespace ApiTestConsoleApp_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var api = new AniListApi();

            //var output = api.GetBasicAnimeByAniListId(21).Result;

            var scum = api.SearchFullAnime("Attack on Titan").Result;


            Console.ReadKey();
        }


    }
}
