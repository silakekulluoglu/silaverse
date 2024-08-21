using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Enums
{
    public enum StandardFilter
    {


        [FilterData(Standard = "3")]
        NGSS = 3,

        [FilterData(Standard = "4")]
        CCSS = 4,
    }
}
