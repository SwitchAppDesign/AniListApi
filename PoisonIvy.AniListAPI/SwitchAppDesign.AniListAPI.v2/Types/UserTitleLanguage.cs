using System.ComponentModel;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Types
{
    public enum UserTitleLanguage
    {
        [ExtendedDescription("The romanization of the native language title")]
        [Description("ROMAJI")]
        Romaji = 1,

        [ExtendedDescription("The official english title")]
        [Description("ENGLISH")]
        English = 2,

        [ExtendedDescription("Official title in it's native language")]
        [Description("NATIVE")]
        Native = 3,

        [ExtendedDescription("The romanization of the native language title, stylised by media creator")]
        [Description("ROMAJI_STYLISED")]
        RomajiStylised = 4,

        [ExtendedDescription("The official english title, stylised by media creator")]
        [Description("ENGLISH_STYLISED")]
        EnglishStylised = 5,

        [ExtendedDescription("Official title in it's native language, stylised by media creator")]
        [Description("NATIVE_STYLISED")]
        NativeStylised = 6
    }
}