namespace Poudlard.Core.Interfaces.Services
{
    public interface IEleveService
    {
        Task<IEnumerable<EleveResponseDto>> RecupererToutLesElevesAsync();
        Task<EleveResponseDto> InscrireEleveAsync(AddEleveRequestDto request);
    }
}
