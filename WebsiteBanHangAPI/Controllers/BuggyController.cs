using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebsiteBanHangAPI.Data;
using WebsiteBanHangAPI.Entities;
using WebsiteBanHangAPI.Entities.Identity;

namespace WebsiteBanHangAPI.Controllers
{
    public class BuggyController : Controller
    {
        private StoreContext _context;

        public BuggyController(StoreContext context) 
        {
            _context = context;
        }
        [Authorize]
        [HttpGet("auth")]
        public ActionResult<string> GetSecret() 
        {
            return "secret text";
        }
        [HttpGet("not-found")]
        public ActionResult<Product> GetNotFound()
        {
            var thing = _context.Products.Find(-1);
            if (thing == null) { return NotFound(); }
            return thing;
        }
        [HttpGet("server-error")]
        public ActionResult<string> GetServerError()
        {
            var thing = _context.Products.Find(-1);
            var thingToReturn = thing.ToString();
            return thingToReturn;
        }
        [HttpGet("bad-request")]
        public ActionResult<string> GetBadRequest()
        {
            return BadRequest("This is not a good request");
        }
    }
}
