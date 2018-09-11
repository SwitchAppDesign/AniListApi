using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class MediaTrailer
    {
        /// <summary>
        /// The trailer video id
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// The site the video is hosted by (Currently either youtube or dailymotion
        /// </summary>
        public string site { get; set; }
    }
}
