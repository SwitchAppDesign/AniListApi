using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Common
{   
    /// <inheritdoc />
    /// <summary>
    /// Exception thrown when a graph query argument is in an invalid state according to its associated rules.
    /// </summary>
    public class GraphQueryArgumentInvalidException : ArgumentException
    {
        public GraphQueryArgumentInvalidException() { }

        public GraphQueryArgumentInvalidException(string message) : base(message) { }

        public GraphQueryArgumentInvalidException(string message, string propertyName) : base(message, propertyName) { }
    }

    /// <inheritdoc />
    /// <summary>
    /// Exception thrown when a graph query argument is in an invalid state according to its associated rules.
    /// </summary>
    public class GraphQueryFieldInvalidException : ArgumentException
    {
        public GraphQueryFieldInvalidException() { }

        public GraphQueryFieldInvalidException(string message) : base(message) { }

        public GraphQueryFieldInvalidException(string message, string propertyName) : base(message, propertyName) { }
    }
}
