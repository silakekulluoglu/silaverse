using DataAccessLayer.Entities;
using Riok.Mapperly.Abstractions;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dtos
{
    public class ThingDetailDto
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Thumbnail { get; set; }
        public string? Url { get; set; }
        public User? Creator { get; set; }
        public DateTime? Added { get; set; }
        public DateTime? Modified { get; set; }
        public int CommentCount { get; set; }
        public int LikeCount { get; set; }
        public int CollectCount { get; set; }
        public ZipData? ZipData { get; set; }
        public string? Details { get; set; }
        public DetailsParts? DetailsParts { get; set; }
        public string? DescriptionHtml { get; set; }
        public List<Tag>? Tags { get; set; }
        public string? License { get; set; }
    }

    [Mapper]
    public static partial class ThingDetailMapper
    {
        public static partial ThingDetailDto ThingToThingDetailDto(ThingDetail thing);
    }

}
