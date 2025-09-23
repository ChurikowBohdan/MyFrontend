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
        public int Id { get; set; }  // ���� ������� id ������

        public void OnGet()
        {
            // ������ �������� ��������
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _trainService.DeleteByIdAsync(Id);
            return RedirectToPage("Read"); // ����� �������� � ��������� � ������ �������
        }
    }
}

