using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class GraphQLQueryArgument<T>
    {
        public GraphQLQueryArgument(string fieldName)
        {
            FieldName = fieldName;
        }

        public string FieldName { get; }
        public T Value { get; private set; }

        /// <summary>
        /// Return the QueryArgument after setting the value.
        /// </summary>
        /// <param name="value">The value used to set the Value property.</param>
        /// <returns>Return the QueryArgument object.</returns>
        public GraphQLQueryArgument<T> GetQueryArgumentAndSetValue(T value)
        {
            SetValue(value);
            return this;
        }

        private void SetValue(T value)
        {
            Value = value;
        }

    }
}
