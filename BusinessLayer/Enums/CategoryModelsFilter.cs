using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Enums
{
    public enum CategoryModelsFilter
    {
        [FilterData(Category = "107")]
        CategoryModelsAnimals = 107,

        [FilterData(Category = "108")]
        CategoryModelsBS = 108,

        [FilterData(Category = "109")]
        CategoryModelsCreatures = 109,

        [FilterData(Category = "110")]
        CategoryModelsFD = 110,

        [FilterData(Category = "111")]
        CategoryModelsFurniture = 111,

        [FilterData(Category = "115")]
        CategoryModelsRobots = 115,

        [FilterData(Category = "112")]
        CategoryModelsPeople = 112,

        [FilterData(Category = "114")]
        CategoryModelsProps = 114,

        [FilterData(Category = "116")]
        CategoryModelsVehicles = 116

    }
}
