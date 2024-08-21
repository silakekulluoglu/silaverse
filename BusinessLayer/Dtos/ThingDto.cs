using DataAccessLayer.Entities;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dtos
{
    public class ThingDto
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string CreatedAt { get; set; }
        public string Thumbnail { get; set; }
    }

    [Mapper]
    public static partial class ThingMapper
    {
        public static partial ThingDto ThingToThingDto(Thing thing);
    }
}
