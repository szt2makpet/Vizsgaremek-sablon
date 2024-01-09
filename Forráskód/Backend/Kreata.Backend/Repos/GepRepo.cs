using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public class GepRepo : IGepRepo
    {
        private readonly KretaInMemoryContext _dbContext;

        public GepRepo(KretaInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GepAdatok?> GetBy(Guid id)
        {
            return await _dbContext.Gepek.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<List<GepAdatok>> GetAll()
        {
            return await _dbContext.Gepek.ToListAsync();
        }
    }
}

