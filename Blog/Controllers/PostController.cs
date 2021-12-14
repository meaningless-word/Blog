using Blog.BLL.DTO;
using Blog.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
	public class PostController : Controller
	{
		private IPostService _postService;
		private ITagService _tagService;
		private ILogger<PostController> _logger;

		public PostController(IPostService postService, ITagService tagService, ILogger<PostController> logger)
		{
			_postService = postService;
			_tagService = tagService;
			_logger = logger;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var posts = await _postService.GetAll();
			return View(posts);
		}

		[HttpGet]
		public IActionResult Create()
		{
			var post = new PostDTO() { AuthorId = new Guid("1869811F-DD39-4C6B-B74F-2452C2848578") };
			ViewBag.Tags = _tagService.GetAll().Result;
			return View(post);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(PostDTO post, Guid[] selectedTags)
		{
			if (ModelState.IsValid)
			{
				post.Tags.AddRange(_tagService.GetAll().Result.Where(x => selectedTags.Contains(x.Id)).Select(x => x));
				_postService.Create(post);
				return RedirectToAction("Index");
			}
			return View(post);
		}
	}
}
