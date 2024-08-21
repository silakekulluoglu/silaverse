using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Enums
{
    public enum CategoryHobbyFilter
    {
        [FilterData(Category = "155")]
        CategoryHobbyAutomotive = 155,

        [FilterData(Category = "93")]
        CategoryHobbyDIY = 93,

        [FilterData(Category = "92")]
        CategoryHobbyElectronics = 92,

        [FilterData(Category = "94")]
        CategoryHobbyMusic = 94,

        [FilterData(Category = "95")]
        CategoryHobbyRCVehicles = 95,

        [FilterData(Category = "96")]
        CategoryHobbyRobotics = 96,

        [FilterData(Category = "140")]
        CategoryHobbySO = 140
    }
}
