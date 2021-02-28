using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msac_fighter.helpers
{
    public static class EnumHelper
    {
        public static string ToDescriptionString(this Enum val)
        {
            var attribute =
                (DescriptionAttribute)
                val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false).
                    SingleOrDefault();
            return attribute == default(DescriptionAttribute) ? val.ToString() : attribute.Description;
        }

        public static List<KeyValuePair<string, string>> GetEnumValueDescriptionPairs(Type enumType)
        {
            return Enum.GetValues(enumType)
                .Cast<Enum>()
                .Select(e => new KeyValuePair<string, string>(e.ToString(), e.ToDescriptionString()))
                .ToList();
        }
    }
}
