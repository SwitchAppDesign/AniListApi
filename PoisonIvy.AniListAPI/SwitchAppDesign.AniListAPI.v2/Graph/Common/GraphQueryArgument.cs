using System;
using System.Collections.Generic;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Common
{
    /// <summary>
    /// A wrapper for a graph query argument.
    /// </summary>
    /// <typeparam name="T">The type of value this class contains.</typeparam>
    public class GraphQueryArgument<T>
    {
        internal GraphQueryArgument(string fieldName, Type parentClassType, AniListQueryType allowedInQueryType, QueryArgumentRules queryArgumentRules)
        {
            FieldName = fieldName;
            ParentClassType = parentClassType;
            AllowedInQueryType = allowedInQueryType;
            QueryArgumentRules = queryArgumentRules;
            GraphQueryArgumentVariableType = GraphHelper.GetGraphVariableType(typeof(T));
        }

        /// <summary>
        /// Raw name of the argument to be used in a graph query.
        /// </summary>
        public string FieldName { get; }

        /// <summary>
        /// The class this fields belongs to.
        /// </summary>
        public Type ParentClassType { get; }

        /// <summary>
        /// The value of the property to be used in a graph query.
        /// </summary>
        public T Value { get; private set; }

        /// <summary>
        /// The rules and contraints to be applied to this argument in a graph query.
        /// </summary>
        public QueryArgumentRules QueryArgumentRules { get; }

        /// <summary>
        /// The graph query arguments variable type.
        /// </summary>
        public string GraphQueryArgumentVariableType { get; }

        /// <summary>
        /// The query type this instance of graph query field is allowed to be used in.
        /// </summary>
        public AniListQueryType AllowedInQueryType { get; }


        /// <summary>
        /// Return the QueryArgument after setting the value.
        /// </summary>
        /// <param name="value">The value used to set the Value property.</param>
        /// <returns>Return the QueryArgument object.</returns>
        public GraphQueryArgument<T> GetQueryArgumentAndSetValue(T value)
        {
            SetValue(value);
            return this;
        }

        private void SetValue(T value)
        {
            Value = value;
        }

        /// <summary>
        /// Validates the current state of the query argument according to its rules.
        /// </summary>
        /// <exception cref="GraphQueryArgumentInvalidException">Thrown if the query argument is in an invalid state.</exception>
        public void Validate(AniListQueryType queryType, bool isAuthenticated, IList<GraphQueryArgument<object>> graphQueryArguments = null)
        {
            if (Value == null)
            {
                throw new GraphQueryArgumentInvalidException(
                    message: $"Argument ({GetType().Name}) must have value.",
                    propertyName: GetType().Name);
            }

            var maxValue = Value.GetType().IsInteger() ? int.Parse($"{Value}") : -1;

            if (!QueryArgumentRules.AllowedQueryTypes.Contains(queryType))
            {
                throw new GraphQueryArgumentInvalidException(
                    message: $"Argument ({GetType().Name}) is not allowed to be used in query type ({queryType.GetDescription()})",
                    propertyName: GetType().Name);
            }

            if (QueryArgumentRules.AuthenticationRequired && !isAuthenticated)
            {
                throw new GraphQueryArgumentInvalidException(
                    message: $"Argument ({GetType().Name}) requires authentication to be accessed.",
                    propertyName: GetType().Name);
            }

            if (QueryArgumentRules.MaxValue.HasValue && maxValue != -1 && maxValue > QueryArgumentRules.MaxValue)
            {
                throw new GraphQueryArgumentInvalidException(
                    message: $"Argument ({GetType().Name}) has a max value of {QueryArgumentRules.MaxValue}",
                    propertyName: GetType().Name);
            }

            if (QueryArgumentRules.RequiresArgument != null && graphQueryArguments != null &&
                graphQueryArguments.All(x => x.FieldName != QueryArgumentRules.RequiresArgument.FieldName))
            {
                throw new GraphQueryArgumentInvalidException(
                    message: $"Argument ({QueryArgumentRules.RequiresArgument.GetType().Name}) is required for argument ({GetType().Name}).",
                    propertyName: GetType().Name);
            }
        }
    }
}
