using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Arguments;
using SwitchAppDesign.AniListAPI.v2.Graph.Fields;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Common
{
    internal static class FieldAndArgumentHelper
    {
        public static void ValidateQueryFieldsAndArguments(GraphQueryField field, IList<GraphQueryField> fields, IList<object> arguments, Type expectedFieldType, Type expectedArgumentType)
        {
            ValidateFields(field, fields, expectedFieldType);
            ValidateArguments(field, arguments, expectedArgumentType);
        }

        public static void ValidateQueryFields(GraphQueryField field, IList<GraphQueryField> fields, Type expectedFieldType)
        {
            ValidateFields(field, fields, expectedFieldType);
        }

        private static void ValidateFields(GraphQueryField field, IList<GraphQueryField> fields, Type expectedFieldType)
        {
            if (fields == null || !fields.Any())
                throw new GraphQueryFieldInvalidException($"Query field '{field.FieldName}' requires at least one query field.");

            if (fields.Any(x => x.ParentClassType != expectedFieldType))
            {
                throw new GraphQueryFieldInvalidException($"The following fields are not valid fields for '{field.FieldName}' {fields.Where(x => x.ParentClassType != field.ChildFieldParentType).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");
            }
        }

        private static void ValidateArguments(GraphQueryField field, IList<object> arguments, Type expectedArgumentType)
        {
            if (arguments != null)
            {
                if (arguments.Any(x => (Type)x.GetType().GetProperty("ParentClassType").GetValue(x) != expectedArgumentType))
                {
                    throw new GraphQueryArgumentInvalidException($@"The following fields are not valid query arguments for the field '{field.FieldName}': {
                        arguments
                            .Where(x => (Type)x.GetType().GetProperty("ParentClassType").GetValue(x) != expectedArgumentType)
                            .Select(x => nameof(x))
                            .Aggregate((x, y) => $"{x}, {y}")}.");
                }

                foreach (var argument in arguments)
                    argument.IsValidArgumentType();
            }
        }
    }
}
