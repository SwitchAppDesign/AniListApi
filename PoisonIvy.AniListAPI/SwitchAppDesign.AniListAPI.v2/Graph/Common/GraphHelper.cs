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
        public static string GetGraphQLVariableType(PropertyInfo prop)
        {
            if (prop.PropertyType.IsArray)
            {
                return prop.PropertyType.GetElementType().IsNullable() 
                    ? $"[{GetGraphTypeFromType(prop.PropertyType.GetElementType())}!]" 
                    : $"[{GetGraphTypeFromType(prop.PropertyType.GetElementType())}]";
            }

            return prop.PropertyType.IsNullable() ? $"{GetGraphTypeFromType(prop.PropertyType)}!" : GetGraphTypeFromType(prop.PropertyType);
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
