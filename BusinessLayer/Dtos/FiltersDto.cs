using BusinessLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dtos
{
    public class FiltersDto
    {
        public string? SearchTerm { get; set; }
        public PostedAfter PostedAfter { get; set; } = PostedAfter.Last30Days;
        public MainCategoriesFilter MainCategory { get; set; }
        public int IsEdu { get; set; }
        public List<SubjectFilter>? Subjects { get; set; }
        public List<GradeLevelFilter>? GradeLevels { get; set; }
        public List<StandardFilter>? Standards { get; set; }
        public LicenseFilter License { get; set; }
        public int Customizable {  get; set; }
        public int ShowCustomizedCreations { get; set; }
        public int OrderPrint { get; set; }
        public int HasMakes { get; set; }
        public int IsFeatured { get; set; }
        public int IsChallangeWinner { get; set; }
        public int IsDerivative { get; set; }
    }
}
