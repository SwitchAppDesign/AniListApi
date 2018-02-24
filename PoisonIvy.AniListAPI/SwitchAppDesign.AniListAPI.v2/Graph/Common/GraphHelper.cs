using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        public static object GetGraphQueryArgumentValue(object argument)
        {
            var value = argument.GetType().GetProperty("Value");
            var actualValue = value.GetValue(argument);
            var type = actualValue.GetType();

            if (type.IsPrimitive || _otherTypes.Contains(type))
            {
                return GetValueFromPrimitive(type, value, argument);
            }

            if (type == typeof(string))
            {
                return $"\"{value.GetValue(argument)}\"";
            }

            if (type.IsEnum)
            {
                return $"{(value.GetValue(argument) as Enum).GetDescription()}";
            }

            if (type.IsArray)
            {
                var result = string.Empty;

                foreach (var item in (IEnumerable)actualValue)
                {
                    var itemType = item.GetType();

                    if (itemType.IsEnum)
                    {
                        result += $"{(item as Enum).GetDescription()}, ";
                    }

                    if (itemType.IsPrimitive)
                    {
                        result += $"{item}, ";
                    }
                }

                return result.Replace(result.Substring(result.LastIndexOf(",", StringComparison.Ordinal)), string.Empty).Trim();
            }

            return "";
        }

        private static readonly List<Type> _otherTypes = new List<Type>
        {
            typeof(String),
            typeof(Int16),
            typeof(Int32),
            typeof(Int64)
        };

        private static object GetValueFromPrimitive(Type type, PropertyInfo value, object argument)
        {
            if (type == typeof(int) || type == typeof(double) || type == typeof(decimal))
            {
                return value.GetValue(argument);
            }

            if (type == typeof(string) || type == typeof(String))
            {
                return $"\"{value.GetValue(argument)}\"";
            }

            if (type == typeof(bool))
            {
                return value.GetValue(argument);
            }

            return null;
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
