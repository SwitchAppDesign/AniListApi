using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class StaffConnection
    {
        public StaffEdge[] edges { get; set; }
        public Staff[] nodes { get; set; }

        /// <summary>
        /// The pagination information
        /// </summary>
        public PageInfo pageInfo { get; set; }
    }
}
