using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum Genres
    {
        [Description("Action")]
        Action = 1,
        [Description("Adventure")]
        Adventure = 2,
        [Description("Comedy")]
        Comedy = 3,
        [Description("Drama")]
        Drama = 4,
        [Description("Ecchi")]
        Ecchi = 5,
        [Description("Fantasy")]
        Fantasy = 6,
        [Description("Hentai")]
        Hentai = 7,
        [Description("Horror")]
        Horror = 8,
        [Description("Mahou Shoujo")]
        MahouShoujo = 9,
        [Description("Mecha")]
        Mecha = 10,
        [Description("Music")]
        Music = 11,
        [Description("Mystery")]
        Mystery = 12,
        [Description("Psychological")]
        Psychological = 13,
        [Description("Romance")]
        Romance = 14,
        [Description("Sci-Fi")]
        SciFi = 15,
        [Description("Slice of Life")]
        SliceOfLife = 16,
        [Description("Sports")]
        Sports = 17,
        [Description("Supernatural")]
        Supernatural = 18,
        [Description("Thriller")]
        Thriller = 19

    }
}
