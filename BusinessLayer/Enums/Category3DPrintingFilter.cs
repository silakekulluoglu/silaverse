using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Enums
{
    public enum Category3DPrintingFilter
    {
        [FilterData(Category = "127")]
        Category3DPrintingAccessories = 127,

        [FilterData(Category = "152")]
        Category3DPrintingExtruders = 152,

        [FilterData(Category = "128")]
        Category3DPrintingParts = 128,

        [FilterData(Category = "126")]
        Category3DPrintingPrinters = 126,

        [FilterData(Category = "129")]
        Category3DPrintingTests = 129
    }
}
