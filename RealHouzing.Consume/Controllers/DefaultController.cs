using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.SubscribeViewModels;
using System.Text;

namespace RealHouzing.Consume.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult Subscribe()
        {
            return PartialView();
        }
        
        [HttpPost]
        public async Task<IActionResult> Subscribe(AddSubscribeViewModel addSubscribeViewModel)
        {
            using (var client = _httpClientFactory.CreateClient())
            {
                string apiUrl = "https://localhost:44345/api/Subscribe";
                var content = new StringContent(JsonConvert.SerializeObject(addSubscribeViewModel), Encoding.UTF8, "application/json");
                var response = await client.PostAsync(apiUrl, content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            return View();
        }
    }
}