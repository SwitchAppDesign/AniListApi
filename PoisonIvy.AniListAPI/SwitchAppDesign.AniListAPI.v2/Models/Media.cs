using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class Media
    {
        /// <summary>
        /// The id of the media
        /// </summary>
        public int? id { get; set; }

        /// <summary>
        /// The mal id of the media
        /// </summary>
        public int? idMal { get; set; }

        /// <summary>
        /// The official titles of the media in various languages
        /// </summary>
        public MediaTitle title { get; set; }

        /// <summary>
        /// The type of the media; anime or manga
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// The format the media was released in
        /// </summary>
        public string format { get; set; }

        /// <summary>
        /// The current releasing status of the media
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// Short description of the media's story and characters
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// The first official release date of the media
        /// </summary>
        public FuzzyDate startDate { get; set; }

        /// <summary>
        /// The last official release date of the media
        /// </summary>
        public FuzzyDate endDate { get; set; }

        /// <summary>
        /// The season the media was initially released in
        /// </summary>
        public string season { get; set; }

        /// <summary>
        /// The amount of episodes the anime has when complete
        /// </summary>
        public int? episodes { get; set; }

        /// <summary>
        /// The general length of each anime episode in minutes
        /// </summary>
        public int? duration { get; set; }

        /// <summary>
        /// The amount of chapters the manga has when complete
        /// </summary>
        public int? chapters { get; set; }

        /// <summary>
        /// The amount of volumes the manga has when complete
        /// </summary>
        public int? volumes { get; set; }

        /// <summary>
        /// Where the media was created. (ISO 3166-1 alpha-2)
        /// </summary>
        public string countryOfOrigin { get; set; }

        /// <summary>
        /// If the media is officially licensed or a self-published doujin release
        /// </summary>
        public bool isLicensed { get; set; }

        /// <summary>
        /// Source type the media was adapted from.
        /// </summary>
        public string source { get; set; }

        /// <summary>
        /// Official Twitter hashtags for the media
        /// </summary>
        public string hashtag { get; set; }

        /// <summary>
        /// Media trailer or advertisement
        /// </summary>
        public MediaTrailer trailer { get; set; }

        /// <summary>
        /// When the media's data was last updated
        /// </summary>
        public int? updatedAt { get; set; }

        /// <summary>
        /// The cover images of the media
        /// </summary>
        public ImageData coverImage { get; set; }

        /// <summary>
        /// The banner image of the media
        /// </summary>
        public string bannerImage { get; set; }

        /// <summary>
        /// The genres of the media
        /// </summary>
        public string[] genres { get; set; }

        /// <summary>
        /// Alternative titles of the media
        /// </summary>
        public string[] synonyms { get; set; }

        /// <summary>
        /// A weighted average score of all the user's scores of the media
        /// </summary>
        public int? averageScore { get; set; }

        /// <summary>
        /// Mean score of all the user's scores of the media
        /// </summary>
        public int? meanScore { get; set; }

        /// <summary>
        /// The number of users with the media on their list
        /// </summary>
        public int? popularity { get; set; }

        /// <summary>
        /// List of tags that describes elements and themes of the media
        /// </summary>
        public MediaTag[] tags { get; set; }

        /// <summary>
        /// Other media in the same or connecting franchise
        /// </summary>
        public MediaConnection relations { get; set; }

        /// <summary>
        /// The characters in the media
        /// </summary>
        public CharacterConnection characters { get; set; }

        /// <summary>
        /// The staff who produced the media
        /// </summary>
        public StaffConnection staff { get; set; }

        /// <summary>
        /// The companies who produced the media
        /// </summary>
        public StudioConnection studios { get; set; }

        /// <summary>
        /// If the media is marked as favourite by the current authenticated user
        /// </summary>
        public bool isFavourite { get; set; }

        /// <summary>
        /// If the media is intended only for 18+ adult audiences
        /// </summary>
        public bool isAdult { get; set; }

        /// <summary>
        /// The media's next episode airing schedule
        /// </summary>
        public AiringSchedule nextAiringEpisode { get; set; }

        /// <summary>
        /// The media's entire airing schedule
        /// </summary>
        public AiringScheduleConnection airingSchedule { get; set; }

        /// <summary>
        /// External links to another site related to the media
        /// </summary>
        public MediaExternalLink[] externalLinks { get; set; }

        /// <summary>
        /// Data and links to legal streaming episodes on external sites
        /// </summary>
        public MediaStreamingEpisode[] streamingEpisodes { get; set; }

        /// <summary>
        /// The ranking of the media in a particular time span and format compared to other media
        /// </summary>
        public MediaRank rankings { get; set; }

        /// <summary>
        /// The authenticated user's media list entry for the media
        /// </summary>
        public MediaList mediaListEntry { get; set; }

        /// <summary>
        /// User reviews of the media
        /// </summary>
        public ReviewConnection reviews { get; set; }

        public MediaStats stats { get; set; }

        /// <summary>
        /// The url for the media page on the AniList website
        /// </summary>
        public string siteUrl { get; set; }

        /// <summary>
        /// If the media should have forum thread automatically created for it on airing episode release
        /// </summary>
        public bool autoCreateForumThread { get; set; }

        /// <summary>
        /// Notes for site moderators
        /// </summary>
        public string modNotes { get; set; }    
    }
}
