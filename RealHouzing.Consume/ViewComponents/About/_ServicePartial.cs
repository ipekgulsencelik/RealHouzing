using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.AboutViewModels;
using RealHouzing.Consume.Models.ServiceItemViewModels;

namespace RealHouzing.Consume.ViewComponents.About
{
    public class _ServicePartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ServicePartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var itemClient = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("https://localhost:44345/api/About");
            var itemResponseMessage = await client.GetAsync("https://localhost:44345/api/ServiceItem");

            if (responseMessage.IsSuccessStatusCode && itemResponseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var jsonDataItem = await itemResponseMessage.Content.ReadAsStringAsync();

                var value = JsonConvert.DeserializeObject<List<AboutListViewModel>>(jsonData);
                var services = JsonConvert.DeserializeObject<List<ServiceItemListViewModel>>(jsonDataItem);

                ViewBag.title = value.Select(x => x.Title).FirstOrDefault();
                ViewBag.description = value.Select(x => x.Description).FirstOrDefault();
                ViewBag.subDescription = value.Select(x => x.Item).FirstOrDefault();
                ViewBag.imageURL = value.Select(x => x.ImageURL).FirstOrDefault();

                return View(services);
            }

            return View();
        }
    }
}