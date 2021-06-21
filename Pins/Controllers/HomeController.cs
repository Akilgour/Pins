using Pins.Application.Contracts.Service;
using Pins.Model;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Pins.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPinService pinService;

        public HomeController(IPinService pinService)
        {
            this.pinService = pinService;
        }

        public async Task<ActionResult> Index()
        {
     
            return View(new NewPin(await pinService.Create()));
        }
    }
}