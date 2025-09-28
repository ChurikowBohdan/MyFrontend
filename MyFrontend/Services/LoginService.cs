using MyFrontend.DTOs;

namespace MyFrontend.Services
{
    public class LoginService
    {
        private readonly HttpClient _http;

        public LoginService(IHttpClientFactory httpClientFactory)
        {
            _http = httpClientFactory.CreateClient("MyApi");
        }

        public async Task CreateAsync(RegistrationDTO data)
        {
            var response = await _http.PostAsJsonAsync("api/register", data);

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException($"Error: {response.StatusCode}");
            }
        }
    }
}
