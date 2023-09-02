using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.BuyLeaseViewModels;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _BuyLeasePartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _BuyLeasePartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44345/api/BuyLease");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<BuyLeaseListViewModel>>(jsonData);

                return View(values);
            }

            return View();
        }
    }
}