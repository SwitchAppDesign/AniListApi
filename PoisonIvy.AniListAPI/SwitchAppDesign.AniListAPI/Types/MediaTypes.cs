using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonIvy.AniListAPI.Types
{
    public enum MediaTypes
    {
        [Description("Not Found")]
        NotFound = -1,
        [Description("TV")]
        TV = 0,
        [Description("TV Short")]
        TVShort = 1, 
        [Description("Movie")]
        Movie = 2,
        [Description("Special")]
        Special = 3,
        [Description("OVA")]
        OVA = 4,
        [Description("ONA")]
        ONA = 5,
        [Description("Music")]
        Music = 6,
        [Description("Manga")]
        Manga = 7,
        [Description("Novel")]
        Novel = 8,
        [Description("One Shot")]
        OneShot = 9,
        [Description("Doujin")]
        Doujin = 10,
        [Description("Manhua")]
        Manhua = 11,
        [Description("Manhwa")]
        Manhwa = 12
    }
}
