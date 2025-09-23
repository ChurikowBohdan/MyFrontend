using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFrontend.DTOs;

namespace MyFrontend.Pages.Trains
{
    public class DeleteModel : PageModel
    {
        private readonly TrainService _trainService;

        public DeleteModel(TrainService trainService)
        {
            _trainService = trainService;
        }

        [BindProperty]
        public int Id { get; set; }  // сюда введЄтс€ id поезда

        public void OnGet()
        {
            // просто показать страницу
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _trainService.DeleteByIdAsync(Id);
            return RedirectToPage("Read"); // после удалени€ Ч вернутьс€ к списку поездов
        }
    }
}

