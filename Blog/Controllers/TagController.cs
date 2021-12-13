using Blog.BLL.DTO;
using Blog.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Blog.Controllers
{
	public class TagController : Controller
	{
		private ITagService _tagService;
		private ILogger<TagController> _logger;

		public TagController(ITagService tagService, ILogger<TagController> logger)
		{
			_tagService = tagService;
			_logger = logger;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var tags = await _tagService.GetAll();
			return View(tags);
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(TagDTO tag)
		{
			if (ModelState.IsValid)
			{
				_tagService.Create(tag);
				return RedirectToAction("Index");
			}
			return View(tag);
		}

		[HttpGet]
		public IActionResult Delete(Guid id)
		{
			var tag = _tagService.GetById(id);
			if (tag == null)
			{
				return NotFound();
			}
			return View(tag);
		}

		[HttpPost]
		public IActionResult Delete(TagDTO tag)
		{
			_tagService.Delete(tag.Id);
			return RedirectToAction("Index");
		}

		
	}
}