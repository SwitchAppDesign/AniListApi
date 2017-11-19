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
        ///// <summary>
        ///// Gets the raw value of a query field.
        ///// </summary>
        ///// <returns></returns>
        //public static string GetGraphQueryFieldValue(GraphQueryField field)
        //{
            
        //}

        /// <summary>
        /// Gets the raw value of a query argument.
        /// </summary>
        /// <returns></returns>
        public static string GetGraphQueryArgumentValue(object argument)
        {
            var value = argument.GetType().GetProperty("Value");
            var type = value.GetType();

            if (type.IsPrimitive)
            {
                if (type == typeof(string))
                {
                    return "String";
                }

                if (type == typeof(int) || type == typeof(double) || type == typeof(decimal))
                {
                    return "Int";
                }

                if (type == typeof(bool))
                {
                    return "Boolean";
                }
            }

            if (type.IsEnum)
            {
                return $"{(value.GetValue(argument) as Enum).GetDescription()}";
            }

            if (type.IsArray)
            {
                var args = type.GetGenericArguments()[0];


            }

            return "";
        }

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
