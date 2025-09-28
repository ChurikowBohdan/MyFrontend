using System.Net.Http.Json;
using MyFrontend.DTOs;

public class StationService
{
    private readonly HttpClient _http;

    public StationService(IHttpClientFactory httpClientFactory)
    {
        _http = httpClientFactory.CreateClient("MyApi");
    }

    public async Task<List<StationReadDTO>> GetAllAsync()
    {
        var stations = await _http.GetFromJsonAsync<List<StationReadDTO>>("api/stations");
        return stations ?? new List<StationReadDTO>();
    }

    public async Task CreateAsync(StationWriteDTO data)
    {
        var response = await _http.PostAsJsonAsync("api/stations", data);

        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException($"Error: {response.StatusCode}");
        }
    }

    public async Task DeleteByIdAsync(int id)
    {
        var response = await _http.DeleteAsync($"api/stations/{id}");

        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException($"Error due station deletion: {response.StatusCode}");
        }
    }

    public async Task UpdateByIdAsync(int id, StationWriteDTO data)
    {
        var response = await _http.PutAsJsonAsync($"api/stations/{id}", data);

        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException($"Error updating station {id}: {response.StatusCode}");
        }
    }
}
