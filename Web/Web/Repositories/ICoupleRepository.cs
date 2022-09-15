using Web.Models;

namespace Web.Repositories
{
    public interface ICoupleRepository
    {
        public IQueryable<Couple> GetCouples();
        public Couple? GetCouple(int id);
        public Task AddCouple(Couple couple);
        public Task UpdateCouple(Couple updatedCouple);
    }
}
