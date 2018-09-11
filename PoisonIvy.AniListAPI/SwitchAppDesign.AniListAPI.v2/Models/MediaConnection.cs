using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class MediaConnection
    {
        public MediaEdge[] edges { get; set; }
        public Media[] nodes { get; set; }

        /// <summary>
        /// The pagination information
        /// </summary>
        public PageInfo pageInfo { get; set; } 
    }
}
