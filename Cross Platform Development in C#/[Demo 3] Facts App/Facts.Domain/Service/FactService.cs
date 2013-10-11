using System.Threading.Tasks;
using Facts.Domain.Entities;
using Facts.Domain.Repository;

namespace Facts.Domain.Service
{
    public class FactService : IFactService
    {
        private readonly IFactRepository _factRepository;

        public FactService(IFactRepository factRepository)
        {
            _factRepository = factRepository;
        }

        public Task<Fact> GetRandomFact()
        {
            return _factRepository.GetFact();
        }
    }
}
