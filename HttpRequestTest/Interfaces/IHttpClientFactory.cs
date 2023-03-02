using HttpRequestExamples.Models;

namespace HttpRequestExamples.Interfaces
{
    public interface IHttpClientFactory
    {
        Task<List<Root>?> GetContent(string address);
    }
}