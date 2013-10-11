using System.Threading.Tasks;
using Facts.Domain.Entities;

namespace Facts.Domain.Service
{
    public interface IFactService
    {
        Task<Fact> GetRandomFact();
    }
}