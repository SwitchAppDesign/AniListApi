using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class MediaList
    {
        /// <summary>
        /// The id of the user
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// The id of the user owner of the list entry
        /// </summary>
        public int userId { get; set; }

        /// <summary>
        /// The id of the media
        /// </summary>
        public int mediaId { get; set; }

        /// <summary>
        /// The watching/reading status
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// The score of the entry
        /// </summary>
        public decimal score { get; set; }

        /// <summary>
        /// The amount of episodes/chapters consumed by the user
        /// </summary>
        public int progress { get; set; }

        /// <summary>
        /// The amount of volumes read by the user
        /// </summary>
        public int progressVolumes { get; set; }

        /// <summary>
        /// The amount of times the user has rewatched/read the media
        /// </summary>
        public int repeat { get; set; }

        /// <summary>
        /// Priority of planning
        /// </summary>
        public int priority { get; set; }

        /// <summary>
        /// If the entry should only be visible to authenticated user
        /// </summary>
        public bool _private { get; set; }

        /// <summary>
        /// Text notes
        /// </summary>
        public string notes { get; set; }

        /// <summary>
        /// If the entry shown be hidden from non-custom lists
        /// </summary>
        public bool hiddenFromStatusLists { get; set; }

        /// <summary>
        /// Map of booleans for which custom lists the entry are in
        /// </summary>
        public string customLists { get; set; }

        /// <summary>
        /// Map of advanced scores with name keys
        /// </summary>
        public string advancedScores { get; set; }

        /// <summary>
        /// When the entry was started by the user
        /// </summary>
        public FuzzyDate startedAt { get; set; }

        /// <summary>
        /// When the entry was completed by the user
        /// </summary>
        public FuzzyDate completedAt { get; set; }

        /// <summary>
        /// When the entry data was last updated
        /// </summary>
        public int updatedAt { get; set; }

        /// <summary>
        /// When the entry data was created
        /// </summary>
        public int createdAt { get; set; }


        public Media media { get; set; }


        public User user { get; set; }
    }
}
