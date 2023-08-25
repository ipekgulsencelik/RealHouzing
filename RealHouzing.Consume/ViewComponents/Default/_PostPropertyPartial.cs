using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.PostingViewModels;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _PostPropertyPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _PostPropertyPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44345/api/Posting");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<PostingListViewModel>>(jsonData);

                return View(values);
            }

            return View();
        }
    }
}
