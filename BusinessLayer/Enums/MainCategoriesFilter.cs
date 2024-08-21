using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Enums
{
    public enum MainCategoriesFilter
    {
        [FilterData(Category = "")]
        AllThings = 1,

        [FilterData(Category = "73")]
        Category3DPrinting = 73,

        [FilterData(Category = "63")]
        CategoryArt = 63,

        [FilterData(Category = "64")]
        CategoryFashion = 64,

        [FilterData(Category = "65")]
        CategoryGadgets = 65,

        [FilterData(Category = "66")]
        CategoryHobby = 66,

        [FilterData(Category = "67")]
        CategoryHousehold = 67,

        [FilterData(Category = "69")]
        CategoryLearning = 69,

        [FilterData(Category = "70")]
        CategoryModels = 70,

        [FilterData(Category = "71")]
        CategoryTools = 71,

        [FilterData(Category = "72")]
        CategoryToysGames = 72,

        [FilterData(Category = "0")]
        CategoryOther = 1000,
    }
}
