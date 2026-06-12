using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryService.WebAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryService.WebAPI.Services
{
    public interface IFraudService
    {
        Task<IEnumerable<Fraud>> GetAll();
        Task<Fraud> Add(Fraud fraud);
    }

    public class FraudService : IFraudService
    {
        private readonly LibraryContext _context;

        public FraudService(LibraryContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Fraud>> GetAll()
        {
            return await _context.Frauds.ToListAsync();
        }

        public async Task<Fraud> Add(Fraud fraud)
        {
            await _context.Frauds.AddAsync(fraud);
            await _context.SaveChangesAsync();
            return fraud;
        }
    }
}