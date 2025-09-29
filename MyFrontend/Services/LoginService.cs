using MyFrontend.DTOs;
using System.Net.Http.Json;

namespace MyFrontend.Services
{
    public class LoginService
    {
        private readonly HttpClient _http;

        public LoginService(IHttpClientFactory httpClientFactory)
        {
            _http = httpClientFactory.CreateClient("MyApi");
        }

        public async Task<TokenResponseDTO> CreateAsync(LoginDTO data)
        {
            var response = await _http.PostAsJsonAsync("api/auth/login", data);

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException($"Error: {response.StatusCode}");
            }

            var tokenDto = await response.Content.ReadFromJsonAsync<TokenResponseDTO>();
            if (tokenDto is null) throw new ApplicationException("Empty token response");
            return tokenDto;
        }
    }
}
