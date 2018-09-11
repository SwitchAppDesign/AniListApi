using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class MediaExternalLink
    {
        /// <summary>
        /// The id of the external link
        /// </summary>
        public int? id { get; set; }

        /// <summary>
        /// The url of the external link
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// The site location of the external link
        /// </summary>
        public string site { get; set; }
    }
}
