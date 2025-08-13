namespace NewsServiceApp.Services
{
    public class NewsService : INewsService
    {
        private readonly HttpClient _httpClient;

        public NewsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetNewsAsync()
        {
            return await _httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
        }
    }
}
