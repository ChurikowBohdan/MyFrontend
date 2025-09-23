using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFrontend.DTOs;

namespace MyFrontend.Pages.Trains
{
    public class UpdateModel : PageModel
    {
        private readonly TrainService _trainService;

        public UpdateModel(TrainService trainService)
        {
            _trainService = trainService;
        }

        [BindProperty]
        public int Id { get; set; }  // Id ������ ��� ������

        [BindProperty]
        public TrainWriteDTO Input { get; set; } = new(); // ������ ��� ��������������

        public bool ShowForm { get; set; } = false; // ���������� ����� ��������������

        // POST: �������� ������ �� Id
        public async Task<IActionResult> OnPostLoadAsync()
        {
            if (Id <= 0)
            {
                ModelState.AddModelError(nameof(Id), "Enter a valid train ID");
                return Page();
            }

            var train = (await _trainService.GetAllAsync()).FirstOrDefault(t => t.TrainId == Id);
            if (train == null)
            {
                ModelState.AddModelError(string.Empty, $"Train with id {Id} not found");
                return Page();
            }

            // ��������� ���� ����� �������� �������
            Input.Name = train.Name;
            Input.NumberOfSeats = train.NumberOfSeats;
            ShowForm = true;

            return Page();
        }

        // POST: ���������� ���������
        public async Task<IActionResult> OnPostUpdateAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _trainService.UpdateByIdAsync(Id, Input);
            return RedirectToPage("Read"); // ����� ���������� � ������� �� ������ �������
        }
    }
}



