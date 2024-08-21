using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class ZipData
    {
        [JsonPropertyName("files")]
        public List<File>? Files { get; set; }

        [JsonPropertyName("images")]
        public List<Image>? Images { get; set; }
    }
}
