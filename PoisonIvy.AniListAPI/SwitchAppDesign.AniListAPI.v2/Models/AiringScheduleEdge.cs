using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class AiringScheduleEdge
    {
        public AiringSchedule node { get; set; }

        /// <summary>
        /// The id of the connection
        /// </summary>
        public int id { get; set; }
    }
}
