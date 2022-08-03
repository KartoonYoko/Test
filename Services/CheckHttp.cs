namespace WebApplication1.Services
{
    public class CheckHttp
    {
        private static HttpClient _httpClient;
        static CheckHttp() {
            _httpClient = new();
        }

        public async Task<string> SendMessage(string url) {
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
