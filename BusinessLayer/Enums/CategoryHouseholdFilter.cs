using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Enums
{
    public enum CategoryHouseholdFilter
    {
        [FilterData(Category = "147")]
        CategoryHouseholdBathroom = 147,

        [FilterData(Category = "146")]
        CategoryHouseholdContainers = 146,

        [FilterData(Category = "97")]
        CategoryHouseholdDecor = 97,

        [FilterData(Category = "99")]
        CategoryHouseholdSupplies = 99,

        [FilterData(Category = "100")]
        CategoryHouseholdKD = 100,

        [FilterData(Category = "101")]
        CategoryHouseholdOO = 101,

        [FilterData(Category = "98")]
        CategoryHouseholdOG = 98,

        [FilterData(Category = "103")]
        CategoryHouseholdPets = 103
    }
}
