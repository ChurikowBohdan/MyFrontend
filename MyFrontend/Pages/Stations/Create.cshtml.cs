using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFrontend.DTOs;
using System.Diagnostics;

namespace MyFrontend.Pages.Stations
{
    public class CreateModel : PageModel
    {
        private readonly StationService _stationService;

        public CreateModel(StationService stationService)
        {
            _stationService = stationService;
        }

        [BindProperty]
        public StationWriteDTO Input { get; set; } = new();
        public string? Message { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _stationService.CreateAsync(Input);

            return RedirectToPage("/Index");
        }
    }
}
