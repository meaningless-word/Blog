using Blog.BLL.DTO;
using Blog.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

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
		[Route("Post/Index/{authorId}")]
		public IActionResult Index(string authorId)
		{
			var posts = _postService.GetPostsByAuthorId(authorId);
			ViewData["authorId"] = authorId;
			return View(posts);
		}

		[HttpGet]
		[Route("Post/Create/{authorId}")]
		public IActionResult Create(string authorId)
		{
			var post = new PostDTO() { AuthorId = authorId };
			ViewBag.Tags = _tagService.GetAll();
			return View(post);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(PostDTO post, string[] selectedTags)
		{
			if (ModelState.IsValid)
			{
				post.TagIds = selectedTags;
				_postService.Create(post);
				return RedirectToAction("Index", "Post", new { authorId = post.AuthorId});
			}
			return View(post);
		}
	}
}
