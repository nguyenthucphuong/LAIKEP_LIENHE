using Lai_Kep.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace Lai_Kep.Controllers
{
    public class LaikepController : Controller
    {
        public IActionResult Index()
        {
              Laikep lai_kep = new Laikep();
              return View(lai_kep);
        }
        [HttpPost]
		
		public IActionResult Index(decimal sotien, double laisuat, int sonam, int soLanGui)
		{
			Laikep lk = new Laikep(sotien, laisuat, sonam, soLanGui);
			return View(lk);
		}
	}
}
