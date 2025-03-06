using Portfolio.Services.DTOs;

namespace Portfolio.Services.Interfaces
{
    public interface IResponsibilityService
    {
        Task<IEnumerable<ResponsibilityDto>> GetResponsibilitiesByPositionId(int positionId);
    }
}
