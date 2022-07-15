using TransScales.Data.Repositries.Interfacies;
using TransScales.Entities.Entities;

namespace TransScales.Data.Repositries.Implementation
{
    public class TransportQuantityRepository : GenericRepository<TransportQuantity>, ITransportQuantityRepository
    {

        public TransportQuantityRepository(TransportDbContext transportDbContext) : base(transportDbContext)
        {

        }
    }
}
