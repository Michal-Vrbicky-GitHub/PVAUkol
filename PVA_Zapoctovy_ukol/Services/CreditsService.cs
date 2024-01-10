using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PVA_Zapoctovy_ukol.Data;
using PVA_Zapoctovy_ukol.Models;

namespace PVA_Zapoctovy_ukol.Services
{
    public class CreditsService : ICreditsService
    {
        private readonly AppDbContext _dbContext;

        public CreditsService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Credit>> GetCreditsAsync()
        {
            return await _dbContext.Credits.ToListAsync();
        }

        public async Task AddCreditAsync(Credit credit)
        {
            _dbContext.Credits.Add(credit);
            await _dbContext.SaveChangesAsync();
        }
    }
}
