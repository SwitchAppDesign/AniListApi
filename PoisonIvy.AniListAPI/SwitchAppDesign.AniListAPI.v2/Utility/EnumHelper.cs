using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Utility
{
    class EnumHelper
    {
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
