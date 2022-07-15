using TransScales.Dto.DtoModels;
using TransScales.Entities.Entities;

namespace TransScales.Data.Repositries.Interfacies
{
    public interface IJournalRepository : IGenericRepository<Journal>
    {
        Task<IEnumerable<Journal>> SearchByNumberandDateAsync(SearchModel searchModel, CancellationToken ct);
    }
}
