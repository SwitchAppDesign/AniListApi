using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class ThreadCategory
    {
        /// <summary>
        /// The id of the category or media is of the media category.
        /// </summary>
        public int? id { get; set; }

        /// <summary>
        /// The name of the category.
        /// </summary>
        public string name { get; set; }
    }
}
