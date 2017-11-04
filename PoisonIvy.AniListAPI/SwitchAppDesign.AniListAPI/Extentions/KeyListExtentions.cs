using System.Collections.Generic;

namespace PoisonIvy.AniListAPI.Extentions
{
    internal static class KeyListExtentions
    {
        public static void Add(this List<KeyValuePair<string, string>> list, string key, string value)
        {
            list.Add(new KeyValuePair<string, string>(key, value));
        }
    }
}
