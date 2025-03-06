using Portfolio.Services.DTOs;

namespace Portfolio.Services.Interfaces
{
    public interface IPositionService
    {
        Task<IEnumerable<PositionDto>> GetAllPositionsAsync();
        Task<PositionDto> GetPositionByIdAsync(int id);
    }
}
