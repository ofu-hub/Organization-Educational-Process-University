using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Repositories;
using Web.Models;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/couple")]
    public class CoupleController : Controller
    {
        private readonly MockCoupleRepository _coupleRepository;

        public CoupleController(MockCoupleRepository repository)
        {
            _coupleRepository = repository;
        }

        public IActionResult Index()
        {
            var couple = _coupleRepository.GetCouples();
            return View(couple);
        }
    }
}
