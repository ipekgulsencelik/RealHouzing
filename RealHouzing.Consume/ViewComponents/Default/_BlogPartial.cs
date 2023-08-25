using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.BlogViewModels;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _BlogPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _BlogPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44345/api/Blog");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<BlogListViewModel>>(jsonData);

                return View(values);
            }

            return View();
        }
    }
}