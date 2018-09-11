using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Utility
{
    /// <summary>
    /// Extensions and helpers for query arguments
    /// </summary>
    public static class ArgumentHelper
    {
        /// <summary>
        /// Checks the argument to ensure it is of the correct type.
        /// </summary>
        public static void IsValidArgumentType(this object argument)
        {
            if (!argument.GetType().IsGenericType)
                throw new Exception("The incorrect argument type provided.");

            if (!argument.GetType().GetGenericArguments().Any())
                throw new Exception("The incorrect argument type provided.");
        }
    }
}
