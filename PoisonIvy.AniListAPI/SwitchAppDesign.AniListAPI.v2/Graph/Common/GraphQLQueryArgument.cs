namespace SwitchAppDesign.AniListAPI.v2.Graph.Common
{
    /// <summary>
    /// A wrapper for a graph query argument.
    /// </summary>
    /// <typeparam name="T">The type of value this class contains.</typeparam>
    public class GraphQLQueryArgument<T>
    {
        internal GraphQLQueryArgument(string fieldName, QueryArgumentRules queryArgumentRules)
        {
            FieldName = fieldName;
            QueryArgumentRules = queryArgumentRules;
        }

        /// <summary>
        /// Raw name of the argument to be used in a graph query.
        /// </summary>
        public string FieldName { get; }

        /// <summary>
        /// The value of the property to be used in a graph query.
        /// </summary>
        public T Value { get; private set; }

        /// <summary>
        /// The rules and contraints to be applied to this argument in a graph query.
        /// </summary>
        public QueryArgumentRules QueryArgumentRules { get; }

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
