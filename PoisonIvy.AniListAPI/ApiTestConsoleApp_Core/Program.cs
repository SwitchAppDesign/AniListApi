using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ApiTestConsoleApp_Core.Tests;
using SwitchAppDesign.AniListAPI.v2;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilderArguments;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders;

namespace ApiTestConsoleApp_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassBuilder.ArgumentFieldClassBuilder.BuildGraphFieldClassesForModels();


            //var test = MediaQueryBuilder.CreateCustomQueryBuilder();
            var mediaTest = new MediaQueryTests();

            mediaTest.Test();


            Console.ReadKey();
        }

        
    }

    class Test
    {
        public int?[] NullableIntArray { get; set; }
    }
}
