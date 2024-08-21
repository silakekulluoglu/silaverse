using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Enums
{
    public enum CategoryGadgetsFilter
    {
        [FilterData(Category = "141")]
        CategoryGadgetsAudio = 141,

        [FilterData(Category = "86")]
        CategoryGadgetsCamera = 86,

        [FilterData(Category = "87")]
        CategoryGadgetsComputer = 87,

        [FilterData(Category = "88")]
        CategoryGadgetsPhone = 88,

        [FilterData(Category = "90")]
        CategoryGadgetsTablet = 90,

        [FilterData(Category = "91")]
        CategoryGadgetsTabletVG = 91
    }
}
