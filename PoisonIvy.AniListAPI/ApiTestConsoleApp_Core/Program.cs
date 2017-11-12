using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SwitchAppDesign.AniListAPI.v2;

namespace ApiTestConsoleApp_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassBuilder.ArgumentFieldClassBuilder.BuildGraphFieldClassesForModels();

            var lst = new List<object>()
            {
                12,
                "Hello"
            };

            foreach (var o in lst)
            {
                Console.WriteLine(o.GetType());
            }


            Console.ReadKey();
        }

        
    }

    class Test
    {
        public int?[] NullableIntArray { get; set; }
    }
}
