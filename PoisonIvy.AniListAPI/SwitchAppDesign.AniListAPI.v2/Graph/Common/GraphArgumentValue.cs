using System;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Common
{
    internal class GraphArgumentValue
    {
        public GraphArgumentValue(object value, Type argumentType)
        {
            Value = value;
            ArgumentType = argumentType;
        }

        public object Value { get; }
        public Type ArgumentType { get; }
    }
}