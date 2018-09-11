using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class StaffEdge
    {
        public Staff node { get; set; }

        /// <summary>
        /// The id of the connection
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// The role of the staff member in the production of the media
        /// </summary>
        public string role { get; set; }

        /// <summary>
        /// The order the staff should be displayed from the users favourites
        /// </summary>
        public int favouriteOrder { get; set; }
    }
}
