using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class StudioEdge
    {
        public Studio node { get; set; }

        /// <summary>
        /// The id of the connection
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// If the studio is the main animation studio of the anime
        /// </summary>
        public bool? isMain { get; set; }

        /// <summary>
        /// The order the character should be displayed from the users favourites
        /// </summary>
        public int favouriteOrder { get; set; }
    }
}
