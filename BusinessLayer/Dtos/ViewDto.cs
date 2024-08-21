using BusinessLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dtos
{
    public class ViewDto
    {
        public List<ThingDto> Things { get; set; }
        public FiltersDto Filters { get; set; } = new FiltersDto();
        public int CurrentPage { get; set; }
        public int PerPage { get; set; }
        public int TotalPages { get; set; }
        public List<SubjectFilter> Subjects { get; set; }

    }
}
