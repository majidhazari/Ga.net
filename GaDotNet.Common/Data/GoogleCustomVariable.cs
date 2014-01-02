using System;
using System.Collections.Generic;
using System.Text;

namespace GaDotNet.Common.Data
{
    public class GoogleCustomVariable
    {
        public string Key;
        public string Value;

        public GoogleCustomVariable()
        {
            
        }

        public GoogleCustomVariable(string key, string value)
        {
            Key = key;
            Value = value;
        }

        private string EscapeString(string val)
        {
            return Uri.EscapeDataString(val).Replace("'", "'0").Replace(")", "'1").Replace("*", "'2").Replace("!", "'3");
        }

        public string EscapedKey()
        {
            return EscapeString(Key);
        }

        public string EscapedValue()
        {
            return EscapeString(Value);
        }
    }
}
