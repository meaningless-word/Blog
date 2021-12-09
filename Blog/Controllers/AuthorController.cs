using Blog.BLL;
using Blog.BLL.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
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
			IEnumerable<AuthorDTO> authors = await _authorService.GetAll();
			return View(authors);
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(AuthorDTO item)
		{
			if (ModelState.IsValid)
			{
				if(_authorService.Create(item))
				  return RedirectToAction("Index");
				ModelState.AddModelError("NickName", "Такая запись уже существует");
			}
			return View(item);
		}
	}
}
