using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Common
{
    internal static class GraphHelper
    {
        /// <summary>
        /// Gets the graph query variable type from the given property.
        /// </summary>
        public static string GetGraphVariableType(Type type)
        {
            if (type.IsPrimitive)
            {
                return type.IsNullable() ? $"{GetGraphTypeFromType(type.DeclaringType)}!" : GetGraphTypeFromType(type);
            }

            if (type.IsArray)
            {
                return type.GetElementType().IsNullable()
                    ? $"[{GetGraphTypeFromType(type.GetElementType())}!]"
                    : $"[{GetGraphTypeFromType(type.GetElementType())}]";
            }

            return type.Name;

        }

        private static string GetGraphTypeFromType(Type propType)
        {
            if (propType == typeof(string))
            {
                return "String";
            }

            if (propType == typeof(int))
            {
                return "Int";
            }

            if (propType == typeof(bool))
            {
                return "Boolean";
            }

            if (propType == typeof(double) || propType == typeof(decimal))
            {
                return "Float";
            }

            return propType.Name;
        }
    }
}
