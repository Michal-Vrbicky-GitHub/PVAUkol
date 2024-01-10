using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using PVA_Zapoctovy_ukol.Models;
using PVA_Zapoctovy_ukol.Services;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace PVA_Zapoctovy_ukol.Pages.Credits
{
    public class AddModel : PageModel
    {
        private readonly ICreditsService _creditsService;

        [BindProperty]
        [Range(1, 5, ErrorMessage = "Value must be between 1 and 5.")]
        public int Value { get; set; }

        [BindProperty]
        public bool Success { get; set; }

        public AddModel(ICreditsService creditsService)
        {
            _creditsService = creditsService;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var newCredit = new Credit
            {
                Value = Value,
                Success = Success,
                Created = DateTime.Now 
            };

            await _creditsService.AddCreditAsync(newCredit);

            return RedirectToPage("/Credits/Index");//
        }
    }
}
