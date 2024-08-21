using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BusinessLayer.Enums
{
    public enum LicenseFilter
    {
        [FilterData(License = "")]
        Any = 1,

        [FilterData(License = "cc")]
        Cc = 2,

        [FilterData(License = "cc-sa")]
        CcSa = 3,

        [FilterData(License = "cc-nd")]
        CcNd = 4,

        [FilterData(License = "cc-nc")]
        CcNc = 5,

        [FilterData(License = "cc-nc-sa")]
        CcNcSa = 6,

        [FilterData(License = "cc-nc-nd")]
        CcNcNd = 7,

        [FilterData(License = "pd0")]
        PublicDomainDedication = 8,

        [FilterData(License = "gpl")]
        GNU_GPL = 9,

        [FilterData(License = "lgpl")]
        GNU_LGPL = 10,

        [FilterData(License = "bsd")]
        BSDLicense = 11,

        [FilterData(License = "none")]
        AllRightsReserved = 12,

        [FilterData(License = "nokia")]
        Nokia = 13,

        [FilterData(License = "public")]
        PublicDomain = 14

    }
}
