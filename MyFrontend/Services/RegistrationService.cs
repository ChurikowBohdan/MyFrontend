using MyFrontend.DTOs;

namespace MyFrontend.Services
{
    public class RegistrationService
    {
        private readonly HttpClient _http;

        public RegistrationService(IHttpClientFactory httpClientFactory)
        {
            _http = httpClientFactory.CreateClient("MyApi");
        }

        public async Task CreateAdminAsync(RegistrationDTO data)
        {
            var response = await _http.PostAsJsonAsync("api/auth/register/admin", data);

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException($"Error: {response.StatusCode}");
            }
        }
        public async Task CreateCustomerAsync(RegistrationDTO data)
        {
            var response = await _http.PostAsJsonAsync("api/auth/register/customer", data);

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException($"Error: {response.StatusCode}");
            }
        }
    }
}
