using Blog.BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Blog.Controllers
{
	public class AuthorController : Controller
	{
		private IAuthorService _authorService;
		private ILogger<AuthorController> _logger;

		public AuthorController(IAuthorService authorService, ILogger<AuthorController> logger)
		{
			_authorService = authorService;
			_logger = logger;
		}

		[HttpGet]
		public async Task<IActionResult> IndexAsync()
		{
			var authors = await _authorService.GetAll();
			return View();
		}
	}
}
