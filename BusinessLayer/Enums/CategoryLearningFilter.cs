using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Enums
{
    public enum CategoryLearningFilter
    {
        [FilterData(Category = "69")]
        CategoryLearning = 69,

        [FilterData(Category = "106")]
        CategoryLearningBiology = 106,

        [FilterData(Category = "104")]
        CategoryLearningEngineering = 104,

        [FilterData(Category = "105")]
        CategoryLearningMath = 105,

        [FilterData(Category = "148")]
        CategoryLearningPA = 148

    }
}
