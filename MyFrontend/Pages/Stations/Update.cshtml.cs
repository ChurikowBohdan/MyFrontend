using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFrontend.DTOs;
using static System.Collections.Specialized.BitVector32;

namespace MyFrontend.Pages.Stations
{
    public class UpdateModel : PageModel
    {
        private readonly StationService _stationService;

        public UpdateModel(StationService stationService)
        {
            _stationService = stationService;
        }

        [BindProperty]
        public int Id { get; set; }  // Id ������ ��� ������

        [BindProperty]
        public StationWriteDTO Input { get; set; } = new(); // ������ ��� ��������������

        public bool ShowForm { get; set; } = false; // ���������� ����� ��������������

        // POST: �������� ������ �� Id
        public async Task<IActionResult> OnPostLoadAsync()
        {
            if (Id <= 0)
            {
                ModelState.AddModelError(nameof(Id), "Enter a valid station ID");
                return Page();
            }

            var station = (await _stationService.GetAllAsync()).FirstOrDefault(t => t.StationId == Id);
            if (station == null)
            {
                ModelState.AddModelError(string.Empty, $"Station with id {Id} not found");
                return Page();
            }

            // ��������� ���� ����� �������� �������
            Input.Name = station.Name;
            Input.StationDistrictName = station.StationDistrictName;
            Input.StationCityName = station.StationCityName;
            Input.NumberOfPlatforms = station.NumberOfPlatforms;
            ShowForm = true;

            return Page();
        }

        // POST: ���������� ���������
        public async Task<IActionResult> OnPostUpdateAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _stationService.UpdateByIdAsync(Id, Input);
            return RedirectToPage("Read"); // ����� ���������� � ������� �� ������ �������
        }
    }
}
