using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class StudioConnection
    {
        public StudioEdge[] edges { get; set; }
        public Studio[] nodes { get; set; }

        /// <summary>
        /// The pagination information
        /// </summary>
        public PageInfo pageInfo { get; set; }
    }
}
