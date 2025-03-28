using Microsoft.AspNetCore.Mvc;
using Portfolio.Services.Interfaces;


namespace Portfolio.Web.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
    public class UserController : Controller
    {
		private readonly IUserService _userService;

		public UserController(IUserService userService)
		{
			_userService = userService;
		}

		//[HttpGet]
		//public async Task<ActionResult<IEnumerable<User>>> GetUsers()
		//{
		//	var users = await _userService.GetAllUsersAsync();
		//	return Ok(users);
		//}

		//[HttpPost]
		//public async Task<ActionResult> CreateUser(User user)
		//{
		//	await _userService.AddUserAsync(user);
		//	return CreatedAtAction(nameof(GetUsers), new { id = user.Id }, user);
		//}
	}
}
