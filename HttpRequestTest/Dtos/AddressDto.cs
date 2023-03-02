using HttpRequestExamples.Models;
using System.Text.Json.Serialization;

namespace HttpRequestExamples.Dtos
{
    public class AddressDto
    {

        [JsonPropertyName("result")]
        public string result { get; set; }
      
    }
}