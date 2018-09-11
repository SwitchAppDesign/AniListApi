using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class StatusDistribution
    {
        /// <summary>
        /// The day the activity took place (Unix timestamp)
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// The amount of entries with this status
        /// </summary>
        public int amount { get; set; }
    }
}
