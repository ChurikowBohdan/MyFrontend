using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFrontend.DTOs;
using System.Net.Http;
using System.Net.Http.Json;

namespace MyFrontend.Pages.Stations
{
    public class ReadModel : PageModel
    {
        private readonly StationService _stationService;

        public List<StationReadDTO> Stations { get; set; } = new();

        public ReadModel(StationService stationService)
        {
            _stationService = stationService;
        }

        public async Task OnGetAsync()
        {

            try
            {
                Stations = await _stationService.GetAllAsync();
            }
            catch (Exception ex)
            {
                //  можно временно логировать ошибку в Output
                Console.WriteLine("Ошибка при запросе API: " + ex.Message);
                Stations = new List<StationReadDTO>();
            }
        }
    }
}
