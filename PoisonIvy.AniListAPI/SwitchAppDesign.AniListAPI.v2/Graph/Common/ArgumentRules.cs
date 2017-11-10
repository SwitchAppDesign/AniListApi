namespace SwitchAppDesign.AniListAPI.v2.Graph.Common
{
    public class ArgumentRules
    {
        public ArgumentRules(bool authenticationRequired, int? maxValue, GraphQLQueryArgument<object> requiresArgument)
        {
            AuthenticationRequired = authenticationRequired;
            MaxValue = maxValue;
            RequiresArgument = requiresArgument;
        }

        public bool AuthenticationRequired { get; }
        public int? MaxValue { get; }
        public GraphQLQueryArgument<object> RequiresArgument { get; }
    }
}