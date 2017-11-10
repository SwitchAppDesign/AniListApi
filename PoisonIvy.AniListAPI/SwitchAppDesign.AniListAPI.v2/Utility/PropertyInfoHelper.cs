using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Utility
{
    public static class PropertyInfoHelper
    {
        public static bool IsNullable(this Type propType)
        {
            return Nullable.GetUnderlyingType(propType.GetElementType()) != null;
        }
    }
}
