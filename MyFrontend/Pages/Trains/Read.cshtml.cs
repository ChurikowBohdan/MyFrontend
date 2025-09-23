using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFrontend.DTOs;
using System.Net.Http;
using System.Net.Http.Json;

public class ReadModel : PageModel
{
    private readonly TrainService _trainService;

    public List<TrainReadDTO> Trains { get; set; } = new();

    public ReadModel(TrainService trainService)
    {
        _trainService = trainService;
    }

    public async Task OnGetAsync()
    {

        try
        {
            Trains = await _trainService.GetAllAsync();
        }
        catch (Exception ex)
        {
            //  можно временно логировать ошибку в Output
            Console.WriteLine("Ошибка при запросе API: " + ex.Message);
            Trains = new List<TrainReadDTO>();
        }
    }
}
