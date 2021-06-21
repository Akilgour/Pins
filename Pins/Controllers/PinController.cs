
using Pins.Application.Contracts.Service;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Pins.Controllers
{
    public class PinController : Controller
    {
        private readonly IPinService pinService;

        public PinController(IPinService pinService)
        {
            this.pinService = pinService;
        }


        public async Task<ActionResult> Index()
        {
         var foo =   await pinService.Create();
            return View();
        }
    }
}