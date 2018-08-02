using GravatarTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace GravatarTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository repository;

        public HomeController(IRepository repository) => this.repository = repository;

        public IActionResult Index() => View(repository);
    }
}
