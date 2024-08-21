using BusinessLayer.Dtos;
using BusinessLayer.ThingService;
using Microsoft.AspNetCore.Mvc;
using LayerP.Models;
using System.Diagnostics;
using System.Collections;
using BusinessLayer.Helpers;

namespace LayerP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GetPopularThings _getPopularThings;

        public HomeController(ILogger<HomeController> logger, GetPopularThings getPopularThings)
        {
            _logger = logger;
            _getPopularThings = getPopularThings;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int page = 1, int per_page = 24)
        {
            List<ThingDto> things = await _getPopularThings.GetPopularThingsAsync(page, per_page, "&sort=popular&posted_after=now-30d", "");
            var totalPages = (int)Math.Ceiling((decimal)_getPopularThings._total / per_page);

            var viewModel = new ViewDto
            {
                Things = things,
                Filters = new FiltersDto(),
                CurrentPage = page,
                PerPage = per_page,
                TotalPages = totalPages
            };
            ViewBag.searchTerm = null;
            return View(viewModel);
        }

        [HttpPost]
        [Route("Home/PopularJson")]
        public async Task<IActionResult> PopularJson([FromBody] FiltersDto request, int page=1, int per_page=12)
        {
            FiltersDto filters = new FiltersDto();
            filters = request;

            var endpoint = helper.ConstructEndpoint(filters);
            List<ThingDto> things = await _getPopularThings.GetPopularThingsAsync(1, 12, endpoint, filters.SearchTerm);
            var totalPages = (int)Math.Ceiling((decimal)_getPopularThings._total / 12);

            var viewModel = new ViewDto
            {
                Things = things,
                Filters = filters,
                CurrentPage = page,
                PerPage = per_page,
                TotalPages = totalPages
            };
            
            ViewBag.searchTerm = filters.SearchTerm;
            return PartialView("~/Views/Shared/_Things.cshtml", viewModel);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       
  
        
    }
}







































/*
       [HttpGet]
       [Route("/Search")]
       public async Task<IActionResult> Search([FromBody] FiltersDto request, int page = 1, int per_page = 12)
       {
           var endpoint = "";

           Console.WriteLine("search");
           FiltersDto filters = new FiltersDto();
           filters = request;
           foreach (var property in typeof(FiltersDto).GetProperties())
           {
               var value = property.GetValue(filters);
               var name = property.Name;

               if (name.ToString() == "SearchTerm")
                   continue;

               if (!IsEmptyOrZero(value))
               {
                   if (value.GetType() != typeof(string) && typeof(IEnumerable).IsAssignableFrom(value.GetType()))
                   {
                       foreach (var item in (IEnumerable)value)
                       {
                           endpoint += GetQuery(name.ToString(), ((int)item).ToString());
                       }
                   }
                   else
                   {
                       endpoint += GetQuery(name.ToString(), ((int)value).ToString());
                   }

               }
           }
           Console.WriteLine(endpoint);
           List<ThingDto> things = await _getPopularThings.GetPopularThingsAsync(1, 12, endpoint, filters.SearchTerm);
           var totalPages = (int)Math.Ceiling((decimal)_getPopularThings._total / 12);

           var viewModel = new ViewDto
           {
               Things = things,
               Filters = filters,
               CurrentPage = page,
               PerPage = per_page,
               TotalPages = totalPages
           };

           return PartialView("Index", viewModel);
       }
       */
