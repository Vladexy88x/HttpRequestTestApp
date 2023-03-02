using HttpRequestExamples.Interfaces;
using HttpRequestExamples.Models;
using System.Text.Encodings.Web;
using System.Text;
using System.Text.Json;
using System.Text.Unicode;
using System.Net.Http.Headers;
using System.Net.Http;
using HttpRequestExamples.Controllers;

namespace HttpRequestExamples.Repositories
{
    public class HttpClientFactory : Interfaces.IHttpClientFactory
    {
        private readonly IConfiguration _configuration;
        private readonly System.Net.Http.IHttpClientFactory _httpClientFactory;
        private readonly ILogger<HttpClientFactory> _logger;

        private readonly string _baseUri;
        private readonly string _token;
        private readonly string _secret;

        public HttpClientFactory(IConfiguration configuration,
             ILogger<HttpClientFactory> logger,
            System.Net.Http.IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration;
            _baseUri = _configuration.GetValue<string>("DadataApi:BaseUrl");
            _token = configuration.GetValue<string>("DadataApi:Token");
            _secret = configuration.GetValue<string>("DadataApi:Secret");
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        public async Task<List<Root>?> GetContent(string address)
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                var options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                    WriteIndented = true
                };
                StringContent dataHttpContent = new StringContent($@"[""{address}""]", Encoding.UTF8, "application/json");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", $"Token {_token}");
                client.DefaultRequestHeaders.Add("X-Secret", _secret);
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36");
                var apiUrl = $"{_baseUri}api/v1/clean/address";
                var response = await client.PostAsync(apiUrl, dataHttpContent);

                var addressData = JsonSerializer.Deserialize<List<Root>>(await response.Content.ReadAsStringAsync());
                return addressData;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error {ex.Message}");
                return null;
            }
        }
    }
}