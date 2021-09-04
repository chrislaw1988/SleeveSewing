using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace SleeveSewing
{
    public class VariableNameAttribute : System.Attribute
    {
        private string _value;

        public VariableNameAttribute(string value)
        {
            _value = value;
        }

        public string VarName
        {
            get { return _value; }
        }
        
    }


    public static class VariableName
    {
        public static string GetVariableName(this Enum value)
        {
            string variableName = null;
            Type type = value.GetType();

            FieldInfo fi = type.GetField(value.ToString());

            VariableNameAttribute[] attributes = fi.GetCustomAttributes(typeof(VariableNameAttribute), false) as VariableNameAttribute[];

            if (attributes.Length > 0)
            {
                variableName = attributes[0].VarName;
            }

            return (variableName);
        }
    }
}
