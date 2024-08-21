using BusinessLayer.Dtos;
using BusinessLayer.ThingService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace LayerP.Controllers
{
    public class ThingController : Controller
    {
        private readonly GetPopularThings _getPopularThings;

        public ThingController(ILogger<HomeController> logger, GetPopularThings getPopularThings)
        {
            _getPopularThings = getPopularThings;
        }
        [HttpGet]
        public async Task<IActionResult> Index(string id, string tabName="thing_details")
        {
            var thingId = Convert.ToInt32(id);
            ThingDetailDto thingDetail = await _getPopularThings.GetThingDetailAsync(thingId);
            Console.WriteLine(thingId);
            ViewBag.tabName = tabName;
            return View(thingDetail);
        }
	}
}
