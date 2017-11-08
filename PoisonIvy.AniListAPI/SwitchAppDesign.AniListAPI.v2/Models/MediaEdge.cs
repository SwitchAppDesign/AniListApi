using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class MediaEdge
    {
        public Media node { get; set; }

        /// <summary>
        /// The id of the connection
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// The type of relation to the parent model
        /// </summary>
        public string relationType { get; set; }

        /// <summary>
        /// If the studio is the main animation studio of the media (For Studio->MediaConnection field only)
        /// </summary>
        public bool? isMainStudio { get; set; }

        /// <summary>
        /// The characters in the media voiced by the parent actor
        /// </summary>
        public Character[] characters { get; set; }

        /// <summary>
        /// The characters role in the media
        /// </summary>
        public string characterRole { get; set; }

        /// <summary>
        /// The role of the staff member in the production of the media
        /// </summary>
        public string staffRole { get; set; }

        /// <summary>
        /// The voice actors of the character
        /// </summary>
        public Staff[] voiceActors { get; set; }

        /// <summary>
        /// The order the media should be displayed from the users favourites
        /// </summary>
        public int favouriteOrder { get; set; }
    }
}
