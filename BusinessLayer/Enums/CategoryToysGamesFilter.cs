using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Enums
{
    public enum CategoryToysGamesFilter
    {
        [FilterData(Category = "151")]
        CategoryToysGamesChess = 151,

        [FilterData(Category = "121")]
        CategoryToysGamesCT = 121,

        [FilterData(Category = "122")]
        CategoryToysGamesDice = 122,

        [FilterData(Category = "123")]
        CategoryToysGamesGames = 123,

        [FilterData(Category = "124")]
        CategoryToysGamesMT = 124,

        [FilterData(Category = "113")]
        CategoryToysGamesPlaysets = 113,

        [FilterData(Category = "125")]
        CategoryToysGamesPuzzles = 125,

        [FilterData(Category = "149")]
        CategoryToysGamesAccessories = 149
    }
}
