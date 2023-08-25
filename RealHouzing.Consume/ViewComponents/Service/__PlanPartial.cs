using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.ServiceViewModels;

namespace RealHouzing.Consume.ViewComponents.Service
{
    public class _PlanPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _PlanPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44345/api/Service");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ServiceListViewModel>>(jsonData);

                return View(values);
            }

            return View();
        }
    }
}
