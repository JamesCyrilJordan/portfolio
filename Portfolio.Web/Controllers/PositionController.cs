using Microsoft.AspNetCore.Mvc;
using Portfolio.Services.Interfaces;

namespace Portfolio.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PositionController : ControllerBase
    {
        private readonly IPositionService _service;
		public PositionController(IPositionService service)
		{
			_service = service;
		}

        [HttpGet]
		public async Task<IActionResult> GetPositions()
        {
            var positions = await _service.GetAllPositionsAsync();
            return Ok(positions);
        }
    }
}
