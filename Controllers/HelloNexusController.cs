using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
 
namespace nexusNet.Controllers {
    public class HelloNexusController : Controller {
        //GET: /HelloNexus/
        public IActionResult Index() {
            return View();
        }
        //GET: /HelloNexus/Welcome/
        public IActionResult BoasVindas() {
            return View();
        }
    }
}