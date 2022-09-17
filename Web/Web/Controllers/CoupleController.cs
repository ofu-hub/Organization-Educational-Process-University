using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Repositories;
using Web.Models.Utils;
using Web.Models;

namespace Web.Controllers
{
    public class CoupleController : Controller
    {
        private readonly ICoupleRepository _coupleRepository;

        public CoupleController(ICoupleRepository repository)
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
