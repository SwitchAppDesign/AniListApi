using System;
using System.Linq;
using System.Reflection;
using SwitchAppDesign.AniListAPI.v2;

namespace ApiTestConsoleApp_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassBuilder.ArgumentFieldClassBuilder.BuildGraphFieldClassesForModels();

            //var type = typeof(Test);

            //foreach (var prop in type.GetProperties())
            //{
            //    if (prop.PropertyType.IsArray)
            //    {
            //        var test = Nullable.GetUnderlyingType(prop.PropertyType.GetElementType());
            //    }
            //    //var test = Nullable.GetUnderlyingType(prop.PropertyType);
            //}

            Console.ReadKey();
        }

        
    }

    class Test
    {
        public int?[] NullableIntArray { get; set; }
    }
}
