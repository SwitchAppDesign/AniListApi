using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class AiringScheduleConnection
    {
        public AiringScheduleEdge[] edges { get; set; }
        public AiringSchedule[] nodes { get; set; }
        public PageInfo pageInfo { get; set; }
    }
}
