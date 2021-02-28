using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msac_fighter.enums
{
    public enum AgeRange
        {
            [Description("0 - 18 years")]
            Youth,
            [Description("18 - 65 years")]
            Adult,
            [Description("65+ years")]
            Senior,
        }
    
}
