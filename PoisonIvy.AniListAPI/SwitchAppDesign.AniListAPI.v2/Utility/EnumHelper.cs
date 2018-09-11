using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Utility
{
    internal static class EnumHelper
    {
        public static string GetDescription(this Enum value)
        {
            var fi = value.GetType().GetField(value.ToString());

            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].Description;
            }

            return value.ToString();
        }

        public static string GetExtendedDescription(this Enum value)
        {
            var fi = value.GetType().GetField(value.ToString());

            var attributes = (ExtendedDescriptionAttribute[])fi.GetCustomAttributes(typeof(ExtendedDescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].ExtendedDescription;
            }

            return value.ToString();
        }
    }

    public class ExtendedDescriptionAttribute : Attribute
    {
        public ExtendedDescriptionAttribute(string extendedDescription)
        {
            ExtendedDescription = extendedDescription;
        }

        public string ExtendedDescription { get; set; }
    }
}
