using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Enums
{
    public enum CategoryArtFilter
    {
        [FilterData(Category = "144")]
        CategoryArt2D = 144,

        [FilterData(Category = "75")]
        CategoryArtTools = 75,

        [FilterData(Category = "143")]
        CategoryArtCB = 143,

        [FilterData(Category = "78")]
        CategoryArtInteractive = 78,

        [FilterData(Category = "79")]
        CategoryArtMath = 79,

        [FilterData(Category = "145")]
        CategoryArtSR = 145,

        [FilterData(Category = "80")]
        CategoryArtSculptures = 80,

        [FilterData(Category = "76")]
        CategoryArtSL = 76
    }
}
