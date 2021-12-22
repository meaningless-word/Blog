using Blog.BLL.DTO;
using Blog.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
		public IActionResult Index()
		{
			var tags = _tagService.GetAll();
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
		public IActionResult Delete(string id)
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

		[HttpGet]
		public IActionResult Update(string id)
		{
			var tag = _tagService.GetById(id);
			if (tag == null)
			{
				return NotFound();
			}
			return View(tag);
		}

		[HttpPost]
		public IActionResult Update(TagDTO tag)
		{
			if (ModelState.IsValid)
			{
				_tagService.Update(tag);
				return RedirectToAction("Index");
			}
			return View(tag);
		}
	}
}