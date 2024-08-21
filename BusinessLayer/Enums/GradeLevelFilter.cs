using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Enums
{
    public enum GradeLevelFilter
    {

        [FilterData(GradeLevel = "15")]
        Kindergarten = 15,

        [FilterData(GradeLevel = "16")]
        Grade1st = 16,

        [FilterData(GradeLevel = "17")]
        Grade2nd = 17,

        [FilterData(GradeLevel = "18")]
        Grade3rd = 18,

        [FilterData(GradeLevel = "19")]
        Grade4th = 19,

        [FilterData(GradeLevel = "20")]
        Grade5th = 20,

        [FilterData(GradeLevel = "21")]
        Grade6th = 21,

        [FilterData(GradeLevel = "22")]
        Grade7th = 22,

        [FilterData(GradeLevel = "23")]
        Grade8th = 23,

        [FilterData(GradeLevel = "24")]
        Grade9th = 24,

        [FilterData(GradeLevel = "25")]
        Grade10th = 25,

        [FilterData(GradeLevel = "26")]
        Grade11th = 26,

        [FilterData(GradeLevel = "27")]
        Grade12th = 27,

        [FilterData(GradeLevel = "28")]
        EducationHigher = 28
    }
}
