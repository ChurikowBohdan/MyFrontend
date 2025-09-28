using System.Net.Http.Json;
using MyFrontend.DTOs;

public class TrainService
{
    private readonly HttpClient _http;

    public TrainService(IHttpClientFactory httpClientFactory)
    {
        _http = httpClientFactory.CreateClient("MyApi");
    }

    public async Task<List<TrainReadDTO>> GetAllAsync()
    {
        var trains = await _http.GetFromJsonAsync<List<TrainReadDTO>>("api/trains");
        return trains ?? new List<TrainReadDTO>();
    }

    public async Task CreateAsync(TrainWriteDTO data)
    {
        var response = await _http.PostAsJsonAsync("api/trains", data);

        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException($"Error: {response.StatusCode}");
        }
    }

    public async Task DeleteByIdAsync(int id)
    {
        var response = await _http.DeleteAsync($"api/trains/{id}");

        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException($"Error due train deletion: {response.StatusCode}");
        }
    }

    public async Task UpdateByIdAsync(int id, TrainWriteDTO data)
    {
        var response = await _http.PutAsJsonAsync($"api/trains/{id}", data);

        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException($"Error updating train {id}: {response.StatusCode}");
        }
    }
}
