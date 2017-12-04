using System;
using System.Collections.Generic;
using System.Text;
using SwitchAppDesign.AniListAPI.v2;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.Builders;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace ApiTestConsoleApp_Core.Tests
{
    public class MediaQueryTests
    {
        public void Test()
        {
            var api = new AniListApi();
            
            var output = api.GetBasicAnimeByAniListId(21).Result;
        }
    }

}
