using TransScales.Dto.DtoModels;

namespace TransScales.Core.Services.Interfacies
{
    public interface ITransportService
    {
        Task<TransportDto> GetRandomTransportAsync(CancellationToken ct);
        Task<List<JournalDto>> SaveTransportWeightAsync(JournalDto journalDto, CancellationToken ct);
        Task CreateNewTransportAsync(TransportDto transportDto, CancellationToken ct);
    }
}
