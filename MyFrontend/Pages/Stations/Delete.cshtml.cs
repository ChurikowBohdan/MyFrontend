using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFrontend.Pages.Stations
{
    public class DeleteModel : PageModel
    {
        private readonly StationService _stationService;

        public DeleteModel(StationService stationService)
        {
            _stationService = stationService;
        }

        [BindProperty]
        public int Id { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _stationService.DeleteByIdAsync(Id);
            return RedirectToPage("Read");
        }
    }
}
