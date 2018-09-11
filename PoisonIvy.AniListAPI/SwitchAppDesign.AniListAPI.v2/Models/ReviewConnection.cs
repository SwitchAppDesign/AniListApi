using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class ReviewConnection
    {
        public ReviewEdge[] edges { get; set; }
        public Review[] nodes { get; set; }

        /// <summary>
        /// The pagination information
        /// </summary>
        public PageInfo pageInfo { get; set; }
    }
}
