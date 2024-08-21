using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class User
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("public_url")]
        public string PublicUrl { get; set; }

        [JsonPropertyName("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonPropertyName("count_of_followers")]
        public int CountOfFollowers { get; set; }

        [JsonPropertyName("count_of_following")]
        public int CountOfFollowing { get; set; }

        [JsonPropertyName("count_of_designs")]
        public int CountOfDesigns { get; set; }

        [JsonPropertyName("collection_count")]
        public int CollectionCount { get; set; }

        [JsonPropertyName("make_count")]
        public int MakeCount { get; set; }

        [JsonPropertyName("accepts_tips")]
        public bool AcceptsTips { get; set; }

        [JsonPropertyName("is_following")]
        public bool IsFollowing { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("cover")]
        public string Cover { get; set; }

        [JsonPropertyName("is_admin")]
        public bool IsAdmin { get; set; }

        [JsonPropertyName("is_moderator")]
        public bool IsModerator { get; set; }

        [JsonPropertyName("is_featured")]
        public bool IsFeatured { get; set; }

        [JsonPropertyName("is_verified")]
        public bool IsVerified { get; set; }
    }
}
