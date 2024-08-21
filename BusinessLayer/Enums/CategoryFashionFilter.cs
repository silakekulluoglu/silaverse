using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Enums
{
    public enum CategoryFashionFilter
    {
        [FilterData(Category = "81")]
        CategoryFashionAccessories = 81,

        [FilterData(Category = "82")]
        CategoryFashionBracelets = 82,

        [FilterData(Category = "142")]
        CategoryFashionCostume = 142,

        [FilterData(Category = "139")]
        CategoryFashionEarrings = 139,

        [FilterData(Category = "83")]
        CategoryFashionGlasses = 83,

        [FilterData(Category = "84")]
        CategoryFashionJewelry = 84,

        [FilterData(Category = "130")]
        CategoryFashionKeychains = 130,

        [FilterData(Category = "85")]
        CategoryFashionRings = 85

    }
}
