using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonIvy.AniListAPI.Types
{
    public enum SeriesType
    {
        [Description("Not Found")]
        NotFound = -1,
        [Description("Anime")]
        Anime = 0,
        [Description("Manga")]
        Manga = 1
    }
}
