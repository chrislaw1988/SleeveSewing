using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Gore.Generic
{
    static internal class EnumUtils
    {
        static public String GetEnumFlagString(Type enumType, int Flags, String Delimeter = "\n")
        {
            Debug.Assert(enumType.IsEnum);

            String EnumFlagString = "";

            Array Values = enumType.GetEnumValues();
            for(int i = 0; i < Values.Length; i++)
            {
                if((Flags & ((int)Values.GetValue(i))) != 0)
                {
                    EnumFlagString += Values.GetValue(i).ToString() + "\n";
                }
            }

            EnumFlagString.TrimEnd(Delimeter.ToCharArray());
            return EnumFlagString;
        }
    }
}
