using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.MessageViewModels;
using System.Text;

namespace RealHouzing.Consume.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(AddMessageViewModel addMessageViewModel)
        {
            using (var client = _httpClientFactory.CreateClient())
            {
                string apiUrl = "https://localhost:44345/api/Message";
                var content = new StringContent(JsonConvert.SerializeObject(addMessageViewModel), Encoding.UTF8, "application/json");
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