using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Common
{
    /// <summary>
    /// A wrapper class for a graph query field.
    /// </summary>
    public class GraphQueryField
    {
        /// <summary>
        /// Initilizes an instance of a GraphQueryField.
        /// </summary>
        /// <param name="fieldName">Raw name of the field to be used in a graph query.</param>
        /// <param name="allowedInQueryType">The query type this instance of graph query field is allowed to be used in.</param>
        /// <param name="rules">The rules and contraints to be applied to this field in a graph query.</param>
        public GraphQueryField(string fieldName, AniListQueryType allowedInQueryType, FieldRules rules)
        {
            FieldName = fieldName;
            Rules = rules;
            AllowedInQueryType = allowedInQueryType;
        }

        /// <summary>
        /// Raw name of the field to be used in a graph query 
        /// </summary>
        public string FieldName { get; }

        /// <summary>
        /// The rules and contraints to be applied to this field in a graph query.
        /// </summary>
        public FieldRules Rules { get; }

        /// <summary>
        /// The arguments to be used in a graph query.
        /// </summary>
        public IEnumerable<GraphQueryArgument<object>> Arguments { get; private set; }

        /// <summary>
        /// The fields to be used in a graph query.
        /// </summary>
        public IEnumerable<GraphQueryField> Fields { get; private set; }

        /// <summary>
        /// The query type this instance of graph query field is allowed to be used in.
        /// </summary>
        public AniListQueryType AllowedInQueryType { get; }

        /// <summary>
        /// Gets the value of the GraphQLQueryField after setting the field arguments value.
        /// </summary>
        /// <param name="fields">The fields to be used in a graph query.</param>
        /// <param name="arguments">The arguments to be used in a graph query.</param>
        public GraphQueryField GetGraphFieldAndSetFieldArguments(IEnumerable<GraphQueryField> fields, IEnumerable<GraphQueryArgument<object>> arguments = null)
        {
            SetFieldArguments(arguments);
            SetFields(fields);
            return this;
        }

        private void SetFieldArguments(IEnumerable<GraphQueryArgument<object>> arguments)
        {
            Arguments = arguments;
        }

        private void SetFields(IEnumerable<GraphQueryField> fields)
        {
            Fields = fields;
        }

        /// <summary>
        /// Validates the current state of the query field according to its rules.
        /// </summary>
        /// <exception cref="GraphQueryFieldInvalidException">Thrown if the query field is in an invalid state.</exception>
        public void Validate(bool isAuthenticated)
        {
            if (Rules.AuthenticationRequired && !isAuthenticated)
            {
                throw new GraphQueryFieldInvalidException($"Field ({GetType().Name}) requires authentication to be accessed.");
            }
        }
    }
}







///// <summary>
///// A wrapper class for a graph query field. 
///// TArgs: The arguments to be used in the graph query.
///// </summary>
//public class GraphQueryField<TArgs>
//{
//    /// <summary>
//    /// Initilizes an instance of a GraphQueryField.
//    /// </summary>
//    /// <param name="fieldName">Raw name of the field to be used in a graph query.</param>
//    /// <param name="rules">The rules and contraints to be applied to this field in a graph query.</param>
//    public GraphQueryField(string fieldName, FieldRules rules)
//    {
//        FieldName = fieldName;
//        Rules = rules;
//    }

//    /// <summary>
//    /// Raw name of the field to be used in a graph query. 
//    /// </summary>
//    public string FieldName { get; }

//    /// <summary>
//    /// 
//    /// </summary>
//    public IList<GraphQueryField> QueryFields { get; }

//    /// <summary>
//    /// The arguments to be used in the graph query.
//    /// </summary>
//    public TArgs FieldArgument { get; private set; }

//    /// <summary>
//    /// The rules and contraints to be applied to this field in a graph query.
//    /// </summary>
//    public FieldRules Rules { get; }

//    /// <summary>
//    /// Gets the value of the GraphQLQueryField after setting the field arguments value.
//    /// </summary>
//    /// <param name="value">The arguments to be used in a graph query.</param>
//    public GraphQueryField<TArgs> GetGraphFieldAndSetFieldArguments(TArgs value)
//    {
//        SetFieldArguments(value);
//        return this;
//    }

//    private void SetFieldArguments(TArgs value)
//    {
//        FieldArgument = value;
//    }

//    /// <summary>
//    /// Validates the current state of the query field according to its rules.
//    /// </summary>
//    /// <exception cref="GraphQueryFieldInvalidException">Thrown if the query field is in an invalid state.</exception>
//    public void IsValid(bool isAuthenticated)
//    {
//        if (Rules.AuthenticationRequired && !isAuthenticated)
//        {
//            throw new GraphQueryFieldInvalidException($"Field ({GetType().Name}) requires authentication to be accessed.");
//        }
//    }
//}