using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonIvy.AniListAPI.Types
{
    public enum Genres
    {
        [Description("Action")]
        Action = 0,
        [Description("Adventure")]
        Adventure = 1,
        [Description("Comedy")]
        Comedy = 2,
        [Description("Drama")]
        Drama = 3,
        [Description("Ecchi")]
        Ecchi = 4,
        [Description("Fantasy")]
        Fantasy = 5,
        [Description("Hentai")]
        Hentai = 6,
        [Description("Horror")]
        Horror = 7,
        [Description("Mahou Shoujo")]
        MahouShoujo = 8,
        [Description("Mecha")]
        Mecha = 9,
        [Description("Music")]
        Music = 10,
        [Description("Mystery")]
        Mystery = 11,
        [Description("Psychological")]
        Psychological = 12,
        [Description("Romance")]
        Romance = 13,
        [Description("SciFi")]
        SciFi = 14,
        [Description("Slice of Life")]
        SliceOfLife = 15,
        [Description("Sports")]
        Sports = 16,
        [Description("Supernatural")]
        Supernatural = 17,
        [Description("Thriller")]
        Thriller = 18
    }
}
