using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PVA_Zapoctovy_ukol.Models;
using PVA_Zapoctovy_ukol.Services;

namespace PVA_Zapoctovy_ukol.Pages.Credits
{
    public class IndexModel : PageModel
    {
        private readonly ICreditsService _creditsService;

        public IndexModel(ICreditsService creditsService)
        {
            _creditsService = creditsService;
        }

        public List<Credit> Credits { get; set; }

        public async Task OnGetAsync()
        {
            Credits = (await _creditsService.GetCreditsAsync()).ToList();
        }

    }
}
