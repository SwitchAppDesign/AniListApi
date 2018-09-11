using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class Review
    {
        /// <summary>
        /// The id of the review
        /// </summary>
        public int? id { get; set; }

        /// <summary>
        /// The id of the review's creator
        /// </summary>
        public int? userId { get; set; }
        
        /// <summary>
        /// The id of the review's media
        /// </summary>
        public int? mediaId { get; set; }
       
        /// <summary>
        /// For which type of media the review is for
        /// </summary>
        public string mediaType { get; set; }
        
        /// <summary>
        /// A short summary of the review
        /// </summary>
        public string summary { get; set; }

        /// <summary>
        /// The main review body text
        /// </summary>
        public string body { get; set; }

        /// <summary>
        /// The total user rating of the review
        /// </summary>
        public int rating { get; set; }

        /// <summary>
        /// The amount of user ratings of the review
        /// </summary>
        public int ratingAmount { get; set; }
        
        /// <summary>
        /// The rating of the review by currently authenticated user
        /// </summary>
        public string userRating { get; set; }
        
        /// <summary>
        /// The review score of the media
        /// </summary>
        public int score { get; set; }
        
        /// <summary>
        /// If the review is not yet publicly published and is only viewable by creator
        /// </summary>
        public bool _private { get; set; }
        
        /// <summary>
        /// The url for the review page on the AniList website
        /// </summary>
        public string siteUrl { get; set; }
        
        /// <summary>
        /// The time of the thread creation
        /// </summary>
        public int? createdAt { get; set; }
        
        /// <summary>
        /// The time of the thread last update
        /// </summary>
        public int? updatedAt { get; set; }
        
        /// <summary>
        /// The creator of the review
        /// </summary>
        public User user { get; set; }

        /// <summary>
        /// The media the review is of
        /// </summary>
        public Media media { get; set; }
    }
}
