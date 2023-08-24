using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.CategoryViewModels;

namespace RealHouzing.Consume.ViewComponents.Service
{
    public class _ExplorePropertyPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ExplorePropertyPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44345/api/Category");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<CategoryListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
