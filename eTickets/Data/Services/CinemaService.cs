using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class CinemaService : ICinemaService
    {
        private readonly AppDbContext _context;

        public CinemaService(AppDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(Cinema cinema)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            var result =  _context.Cinemas.FirstOrDefault(n => n.CinemaId == id);

            if (result != null)
            {
                _context.Cinemas.Remove(result);
            }
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Cinema>> GetAllAsync()
        {
            var result =  await _context.Cinemas.ToListAsync();
            return result;
        }

        public async Task<Cinema> GetByIdAsync(int id)
        {
            var result = await _context.Cinemas.FirstOrDefaultAsync(n => n.CinemaId == id);
            return result;
        }

        public Task<Cinema> UpdateAsync(int id, Cinema newCinema)
        {
            throw new NotImplementedException();
        }
    }
}
