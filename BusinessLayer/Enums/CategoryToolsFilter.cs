using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Enums
{
    public enum CategoryToolsFilter
    {
        [FilterData(Category = "118")]
        CategoryToolsHand = 118,

        [FilterData(Category = "117")]
        CategoryToolsMachine = 117,

        [FilterData(Category = "120")]
        CategoryToolsHB = 120
    }
}
