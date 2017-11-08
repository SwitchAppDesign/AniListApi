using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class CharacterEdge
    {
        /// <summary>
        /// 
        /// </summary>
        public Character node { get; set; }

        /// <summary>
        /// The id of the connection
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// The characters role in the media
        /// </summary>
        public string role { get; set; }

        /// <summary>
        /// The voice actors of the character
        /// </summary>
        public Staff[] voiceActors { get; set; }

        /// <summary>
        /// The media the character is in
        /// </summary>
        public Media[] media { get; set; }

        /// <summary>
        /// The order the character should be displayed from the users favourites
        /// </summary>
        public int favouriteOrder { get; set; }
    }
}
