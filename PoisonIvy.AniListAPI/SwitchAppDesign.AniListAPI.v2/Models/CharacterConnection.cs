using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class CharacterConnection
    {
        public CharacterEdge[] edges { get; set; }
        public Character[] nodes { get; set; }

        /// <summary>
        /// The pagination information
        /// </summary>
        public PageInfo pageInfo { get; set; } 
    }
}
