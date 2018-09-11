using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class ImageData
    {
        /// <summary>
        /// The image at its largest size
        /// </summary>
        public string large { get; set; }

        /// <summary>
        /// The cover image of media at medium size
        /// </summary>
        public string medium { get; set; }
    }
}
