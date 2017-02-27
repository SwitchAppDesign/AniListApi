using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoisonIvy.AniListAPI.Helpers;

namespace PoisonIvy.AniListAPI.Extentions
{
    internal static class ExtensionMethods
    {
        public static TEnum GetEnumValue<TEnum>(this string source)
            where TEnum : struct, IConvertible
        {
            if (!typeof(TEnum).IsEnum)
            {
                throw new ArgumentException("TEnum must be an enumerated type");
            }

            if (string.IsNullOrWhiteSpace(source))
            {
                return new TEnum();
            }

            source = source.ToLower();

            var enumValues = Enum.GetValues(typeof(TEnum)).OfType<TEnum>().ToList();
            return enumValues.FirstOrDefault(x => ((Enum)(object)x).GetLoweredDescription() == source);
        }
    }
}
