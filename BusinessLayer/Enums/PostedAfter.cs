using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BusinessLayer.Enums
{
    public enum PostedAfter
    {
        [FilterData(Sort = "popular", PostedAfter = "now-30d")]
        Last30Days = 30,

        [FilterData(Sort = "popular", PostedAfter = "now-7d")]
        Last7Days = 7,

        [FilterData(Sort = "popular", PostedAfter = "now-365d")]
        ThisYear = 365,

        [FilterData(Sort = "newest")]
        Newest = 2,

        [FilterData(Sort = "makes")]
        Makes = 3,

        [FilterData(Sort = "popular")]
        AllTime = 4,

        Relevant = 5,

        Text = 6
    }
}
