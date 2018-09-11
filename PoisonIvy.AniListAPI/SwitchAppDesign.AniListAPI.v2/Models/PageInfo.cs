using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class PageInfo
    {
        /// <summary>
        /// The total number of items
        /// </summary>
        public int total { get; set; }

        /// <summary>
        /// The count on a page
        /// </summary>
        public int perPage { get; set; }

        /// <summary>
        /// The current page
        /// </summary>
        public int currentPage { get; set; }

        /// <summary>
        /// The last page
        /// </summary>
        public int lastPage { get; set; }

        /// <summary>
        /// If there is another page
        /// </summary>
        public bool hasNextPage { get; set; }
    }
}
