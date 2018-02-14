using Microsoft.AspNetCore.Mvc;
using Test1.Services;

namespace Test1.Controllers
{
    [Route("/")]
    public class DogController : Controller
    {
        public DogService DogService { get; set; }
        public DogController(DogService dogService)
        {
            DogService = dogService;
        }

        [Route("/")]
        public IActionResult Dogs()
        {
            return View();
        }

        [HttpGet("hello")]
        public IActionResult Hello()
        {
            DogService.AddDog();
            return Json(DogService.GetDogs());
        }

       

    }
}
