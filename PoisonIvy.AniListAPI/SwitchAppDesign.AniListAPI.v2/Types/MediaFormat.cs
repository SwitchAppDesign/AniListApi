using System.ComponentModel;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum MediaFormat
    {
        [ExtendedDescription("Anime broadcast on television")]
        [Description("TV")]
        Tv = 1,
        [ExtendedDescription("Anime which are under 15 minutes in length and broadcast on television")]
        [Description("TV_SHORT")]
        TvShort = 2,
        [ExtendedDescription("Anime movies with a theatrical release")]
        [Description("MOVIE")]
        Movie = 3,
        [ExtendedDescription("Special episodes that have been included in DVD/Blu-ray releases, picture, dramas, pilots, etc"))]
        [Description("SPECIAL")]
        Special = 4,
        [ExtendedDescription("(Original Video Animation) Anime that have been released directly on DVD/Blu-ray without originally going through a theatrical release or television broadcast")]
        [Description("OVA")]
        Ova = 5,
        [ExtendedDescription("(Original Net Animation) Anime that have been originally released online or are only available through streaming services.")]
        [Description("ONA")]
        Ona = 6,
        [ExtendedDescription("Short anime released as a music video")]
        [Description("MUSIC")]
        Music = 7,
        [ExtendedDescription("Professionally published manga with more than one chapter")]
        [Description("MANGA")]
        Manga = 8,
        [ExtendedDescription("Written books released as a novel or series of light novels")]
        [Description("NOVEL")]
        Novel = 9,
        [ExtendedDescription("Manga with just one chapter")]
        [Description("ONE_SHOT")]
        OneShot = 10
    }
}