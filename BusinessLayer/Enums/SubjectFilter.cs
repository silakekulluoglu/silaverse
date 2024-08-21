using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Enums
{
    public enum SubjectFilter
    {

        [FilterData(Subject = "11")]
        Science = 11,

        [FilterData(Subject = "12")]
        Math = 12,

        [FilterData(Subject = "13")]
        Engineering = 13,

        [FilterData(Subject = "14")]
        History = 14,

        [FilterData(Subject = "15")]
        Geography = 15,

        [FilterData(Subject = "16")]
        Art = 16,

        [FilterData(Subject = "17")]
        Languages = 17,

        [FilterData(Subject = "18")]
        Music = 18,

        [FilterData(Subject = "19")]
        Technology = 19,

        [FilterData(Subject = "20")]
        SpecialEd = 20,
    }
}
