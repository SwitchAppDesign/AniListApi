using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class UserActivityHistory
    {
        /// <summary>
        /// The day the activity took place (Unix timestamp)
        /// </summary>
        public int date { get; set; }

        /// <summary>
        /// The amount of activity on the day
        /// </summary>
        public int amount { get; set; }

        /// <summary>
        /// The level of activity represented on a 1-10 scale
        /// </summary>
        public int level { get; set; }
    }
}
