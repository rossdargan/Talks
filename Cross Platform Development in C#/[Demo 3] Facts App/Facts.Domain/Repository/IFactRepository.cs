using System.Threading.Tasks;
using Facts.Domain.Entities;

namespace Facts.Domain.Repository
{
    public interface IFactRepository
    {
        Task<Fact> GetFact();
    }
}
