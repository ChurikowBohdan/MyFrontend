using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFrontend.DTOs;
using System.Diagnostics;

namespace MyFrontend.Pages.Trains
{
    public class CreateModel : PageModel
    {
        private readonly TrainService _trainService;

        public CreateModel(TrainService trainService)
        {
            _trainService = trainService;
        }

        [BindProperty]
        public TrainWriteDTO Input { get; set; } = new();
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

            await _trainService.CreateAsync(Input);

            return RedirectToPage("/Index");
        }
    }
}
