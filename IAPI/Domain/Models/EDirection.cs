using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace IAPI.Domain.Models
{
    public enum EDirection
    {
        [Description("N")]
        North = 1,     

        [Description("E")]
        East =2,

        [Description("S")]
        South = 3,

        [Description("W")]
        West = 4

    }
}
