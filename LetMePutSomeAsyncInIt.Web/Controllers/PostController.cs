using LetMePutSomeAsyncInIt.Web.Repositories.Interfaces;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LetMePutSomeAsyncInIt.Web.Controllers
{
    [RoutePrefix("Post")]
    public class PostController : Controller
    {
        private IPostRepository _postRepo;

        public PostController(IPostRepository postRepo)
        {
            _postRepo = postRepo;
        }

        [HttpGet]
        [Route("")]
        [Route("Index")]
        public async Task<ActionResult> Index()
        {
            var allPosts = await _postRepo.GetAll();
            return View(allPosts);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetByID(int id)
        {
            var post = await _postRepo.GetByID(id);
            return View(post);
        }
    }
}