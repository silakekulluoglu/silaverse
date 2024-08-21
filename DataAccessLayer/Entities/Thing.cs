using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Thing
    {
        [Key]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("public_url")]
        public string PublicUrl { get; set; }

        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        [JsonPropertyName("thumbnail")]
        public string? Thumbnail { get; set; }

        [JsonPropertyName("preview_image")]
        public string? PreviewImage { get; set; }

        [JsonPropertyName("creator")]
        public User? Creator { get; set; }

        [JsonPropertyName("is_private")]
        public int? IsPrivate { get; set; }

        [JsonPropertyName("is_purchased")]
        public int? IsPurchased { get; set; }

        [JsonPropertyName("is_published")]
        public int? IsPublished { get; set; }

        [JsonPropertyName("is_featured")]
        public bool? IsFeatured { get; set; }

        [JsonPropertyName("is_edu_approved")]
        public int? IsEduApproved { get; set; }

        [JsonPropertyName("is_printable")]
        public bool? IsPrintable { get; set; }

        [JsonPropertyName("is_winner")]
        public bool? IsWinner { get; set; }

        [JsonPropertyName("comment_count")]
        public int? CommentCount { get; set; }

        [JsonPropertyName("make_count")]
        public int? MakeCount { get; set; }

        [JsonPropertyName("like_count")]
        public int? LikeCount { get; set; }

        [JsonPropertyName("tags")]
        public List<Tag>? Tags { get; set; }

        [JsonPropertyName("is_nsfw")]
        public bool? IsNsfw { get; set; }

        [JsonPropertyName("rank")]
        public int? Rank { get; set; }

        [JsonPropertyName("collect_count")]
        public int? CollectCount { get; set; }

        [JsonPropertyName("moderation")]
        public string? Moderation { get; set; }

        [JsonPropertyName("is_banned")]
        public bool? IsBanned { get; set; }

        [JsonPropertyName("needs_moderation")]
        public int? NeedsModeration { get; set; }

        [JsonPropertyName("is_comments_disabled")]
        public bool? IsCommentsDisabled { get; set; }

        [JsonPropertyName("added")]
        public DateTime? Added { get; set; } // string date time ??

        [JsonPropertyName("modified")]
        public DateTime? Modified { get; set; }
        public int? IsWip { get; set; }
        public bool? IsLiked { get; set; }
        public bool? IsCollected { get; set; }
        public bool? IsWatched { get; set; }
        public DefaultImage? DefaultImage { get; set; } //img
        public string? Description { get; set; }
        public string? Instructions { get; set; }

        [JsonPropertyName("description_html")]
        public string? DescriptionHtml { get; set; }
        public string? InstructionsHtml { get; set; }

        [JsonPropertyName("details")]
        public string? Details { get; set; }

        [JsonPropertyName("details_parts")]
        public DetailsParts? DetailsParts { get; set; } // bi bak
        public string? EduDetails { get; set; }
        public DetailsParts? EduDetailsPart{ get; set; }

        [JsonPropertyName("license")]
        public string? License { get; set; }
        public bool? AllowsDerivatives { get; set; }
        public string? FilesUrl { get; set; }
        public string? ImagesUrl { get; set; }
        public string? LikesUrl { get; set; }
        public string? AncestorsUrl { get; set; }
        public string? DerivativesUrl { get; set; }
        public string? TagsUrl { get; set; }
        public string? CategoriesUrl { get; set; }
        public int? FileCount { get; set; }
        public int? AppId { get; set; }
        public int? DownloadCount { get; set; }
        public int? ViewCount { get; set; }
        public Education? Education { get; set; }
        public int? RemixCount { get; set; }
        public int? AppCount { get; set; }
        public int? RootCommentCount { get; set; }
        public bool? IsDerivative {  get; set; }
        public Ancestors? Ancestors { get; set; }
        public bool? CanComment { get; set; }
        public string? TypeName { get; set; }

        [JsonPropertyName("zip_data")]
        public ZipData? ZipData { get; set; }

    }
}
