using System;
using System.Collections.Generic;
using System.Text;
using SwitchAppDesign.AniListAPI.v2;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace ApiTestConsoleApp_Core.Tests
{
    public class MediaQueryTests
    {
        public void Test()
        {
            var builder = MediaQueryBuilder.CreateCustomerQueryBuider(AniListQueryType.Media);

            builder.GraphQueryFields.Add(
                builder.MediaQueryFields.TitleQueryField(
                    new List<GraphQueryField>
                    {
                        builder.AdditionalAvailableFields.MediaTitleQueryFields.EnglishQueryField(),
                        builder.AdditionalAvailableFields.MediaTitleQueryFields.RomajiQueryField()
                    }));
            builder.GraphQueryFields.Add(builder.MediaQueryFields.SeasonQueryField());
            //builder.GraphQueryFields.Add(builder.MediaQueryFields.CharactersQueryField(
            //    new List<GraphQueryField>
            //    {
            //        builder.AdditionalAvailableFields.CharacterConnectionQueryFields.EdgesQueryField()
            //    }));

            builder.AddArgument(builder.MediaQueryArguments.TypeArgument(MediaType.Anime));

            var api = new AniListApi();
            api.Test(builder);
        }
    }

}
