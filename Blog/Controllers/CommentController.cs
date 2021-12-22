using Blog.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Blog.Controllers
{
    public class CommentController : Controller
    {
        private ICommentService _commentService;
        private ILogger<CommentController> _logger;

        public CommentController(ICommentService commentService, ILogger<CommentController> logger)
        {
            _commentService = commentService;
            _logger = logger;
        }
        
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}