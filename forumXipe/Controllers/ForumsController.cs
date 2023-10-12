using forumxipe.Application.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace forumXipe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForumsController : ControllerBase
    {
        private readonly IForumService _forumService;

        public ForumsController(IForumService forumService)
        {
            _forumService = forumService;
        }
        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok();
        }
    }
}
