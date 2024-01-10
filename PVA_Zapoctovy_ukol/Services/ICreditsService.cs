using System.Collections.Generic;
using System.Threading.Tasks;
using PVA_Zapoctovy_ukol.Models;

namespace PVA_Zapoctovy_ukol.Services
{
    public interface ICreditsService
    {
        Task<IEnumerable<Credit>> GetCreditsAsync();
        Task AddCreditAsync(Credit credit);
    }
}
