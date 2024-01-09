using Kreata.Backend.Datas.Entities;

namespace Kreata.Backend.Repos
{
    public interface IGepRepo
    {
        Task<List<GepAdatok>> GetAll();
        Task<GepAdatok?> GetBy(Guid id);
    }
}
