using TransScales.Data.Repositries.Interfacies;
using TransScales.Entities.Entities;

namespace TransScales.Data.Repositries.Implementation
{
    public class TransportRepository : GenericRepository<Transport>, ITransportRepository
    {
        public TransportRepository(TransportDbContext transportDbContext) : base(transportDbContext)
        {

        }
    }
}
