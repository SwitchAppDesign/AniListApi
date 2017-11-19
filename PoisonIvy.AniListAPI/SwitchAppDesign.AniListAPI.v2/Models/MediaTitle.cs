using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class MediaTitle
    {
        /// <summary>
        /// The romanization of the native language title
        /// </summary>
        public string romaji { get; set; }

        /// <summary>
        /// The official english title
        /// </summary>
        public string english { get; set; }

        /// <summary>
        /// Official title in it's native language
        /// </summary>
        public string native { get; set; }

        /// <summary>
        /// The currently authenticated users preferred title language. Default romaji for non-authenticaed
        /// </summary>
        public string userPreferred { get; set; }
    }
}
