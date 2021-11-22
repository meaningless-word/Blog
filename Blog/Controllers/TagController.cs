using System.Threading.Tasks;
using Blog.BLL;
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
        
        // GET
        public async Task<IActionResult> Index()
        {
            var tags = await _tagService.GetAll();
            return View(tags);
        }
    }
}