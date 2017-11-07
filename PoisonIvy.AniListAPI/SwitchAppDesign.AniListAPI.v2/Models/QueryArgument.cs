using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class QueryArgument
    {
        public QueryArgument(string fieldName)
        {
            FieldName = fieldName;
        }

        public string FieldName { get; set; }
        public object Value { get; private set; }

        public void SetValue(object value)
        {
            Value = value;
        }
    }
}
