using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Common
{
    /// <summary>
    /// A wrapper class for a graph query field. 
    /// TArgs: The arguments to be used in the graph query.
    /// </summary>
    public class GraphQLQueryField<TArgs>
    {
        /// <summary>
        /// Initilizes an instance of a GraphQueryField.
        /// </summary>
        /// <param name="fieldName">Raw name of the field to be used in a graph query.</param>
        /// <param name="rules">The rules and contraints to be applied to this field in a graph query.</param>
        public GraphQLQueryField(string fieldName, FieldRules rules)
        {
            FieldName = fieldName;
            Rules = rules;
        }


        /// <summary>
        /// Raw name of the field to be used in a graph query. 
        /// </summary>
        public string FieldName { get; }

        /// <summary>
        /// The arguments to be used in the graph query.
        /// </summary>
        public TArgs FieldArguments { get; private set; }

        /// <summary>
        /// The rules and contraints to be applied to this field in a graph query.
        /// </summary>
        public FieldRules Rules { get; }

        /// <summary>
        /// Gets the value of the GraphQLQueryField after setting the field arguments value.
        /// </summary>
        /// <param name="value">The arguments to be used in a graph query.</param>
        public GraphQLQueryField<TArgs> GetGraphFieldAndSetFieldArguments(TArgs value)
        {
            SetFieldArguments(value);
            return this;
        }

        private void SetFieldArguments(TArgs value)
        {
            FieldArguments = value;
        }
    }

    /// <summary>
    /// A wrapper class for a graph query field.
    /// </summary>
    public class GraphQLQueryField
    {
        /// <summary>
        /// Initilizes an instance of a GraphQueryField.
        /// </summary>
        /// <param name="fieldName">Raw name of the field to be used in a graph query.</param>
        /// <param name="rules">The rules and contraints to be applied to this field in a graph query.</param>
        public GraphQLQueryField(string fieldName, FieldRules rules)
        {
            FieldName = fieldName;
            Rules = rules;
        }

        /// <summary>
        /// Raw name of the field to be used in a graph query 
        /// </summary>
        public string FieldName { get; }

        /// <summary>
        /// The rules and contraints to be applied to this field in a graph query.
        /// </summary>
        public FieldRules Rules { get; }
    }
}