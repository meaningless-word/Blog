using Blog.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
	public class PostController : Controller
	{
		private IPostService _postService;
		private ILogger<PostController> _logger;

		public PostController(IPostService postService, ILogger<PostController> logger)
		{
			_postService = postService;
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
			return View();
		}


	}
}
