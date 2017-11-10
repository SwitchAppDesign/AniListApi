namespace SwitchAppDesign.AniListAPI.v2.Graph.Common
{
    public class GraphQLQueryField
    {
        public GraphQLQueryField(string fieldName, FieldRules rules)
        {
            FieldName = fieldName;
            Rules = rules;
        }

        public string FieldName { get; }
        public FieldRules Rules { get; }
    }
}