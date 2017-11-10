namespace SwitchAppDesign.AniListAPI.v2.Graph.Common
{
    public class FieldRules
    {
        public FieldRules(bool authenticationRequired)
        {
            AuthenticationRequired = authenticationRequired;
        }

        public bool AuthenticationRequired { get; }
    }
}