using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.OptionViewModels;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _OptionPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _OptionPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44345/api/Option");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<OptionListViewModel>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
