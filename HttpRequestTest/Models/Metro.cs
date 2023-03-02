using System.Text.Json.Serialization;

namespace HttpRequestExamples.Models
{
    public class Metro
    {
        [JsonPropertyName("distance")]
        public double? distance { get; set; }

        [JsonPropertyName("line")]
        public string? line { get; set; }

        [JsonPropertyName("name")]
        public string? name { get; set; }
    }
}
