using Microsoft.AspNetCore.Mvc;

namespace Lai_Kep.Controllers
{
	public class LienHeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(string hoTen, DateTime ngaySinh, string eMail, string dienThoai)
		{
			ViewData["hoTen"] = hoTen;
			ViewData["ngaySinh"] = ngaySinh.ToString("yyyy-MM-dd");
			ViewData["eMail"] = eMail;
			ViewData["dienThoai"] = dienThoai;
			return View();
		}
	}
}
