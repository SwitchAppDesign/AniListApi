﻿using System;
using System.Collections.Generic;
using System.Text;
using SwitchAppDesign.AniListAPI.v2;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace ApiTestConsoleApp_Core.Tests
{
    public class MediaQueryTests
    {
        public void Test()
        {
            var builder = MediaQueryBuilder.CreateCustomerQueryBuider();

            //builder.GraphQueryFields.Add(
            //    builder.MediaQueryFields.TitleQueryField(
            //        new List<GraphQueryField>
            //        {
            //            builder.AdditionalAvailableFields.MediaTitleQueryFields.EnglishQueryField(),
            //            builder.AdditionalAvailableFields.MediaTitleQueryFields.RomajiQueryField()
            //        }));

            //var test = ;

            //Dam(test);

            builder.AddArgument(builder.MediaQueryArguments.TypeArgument(MediaType.Anime));
            var api = new AniListApi();
            api.Test(builder);
        }

        private void Dam(object arg)
        {
            var type = arg.GetType();
            Console.WriteLine(type);

            if (type.IsGenericType)
            {
               var damson = type.GetGenericArguments();

                //Console.WriteLine(damson);
                Console.WriteLine(damson[0]);
            }
        }
    }
}