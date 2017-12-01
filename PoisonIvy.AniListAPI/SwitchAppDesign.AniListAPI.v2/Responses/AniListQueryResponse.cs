using System;
using System.Collections.Generic;
using System.Text;
using SwitchAppDesign.AniListAPI.v2.Models;

namespace SwitchAppDesign.AniListAPI.v2.Responses
{
    internal class AniListQueryResponse
    {
        public AniListApiResponseData data { get; set; }
    }

    internal class AniListApiResponseData
    {
        public Dictionary<string, object> Value { get; set; }
    }
}
