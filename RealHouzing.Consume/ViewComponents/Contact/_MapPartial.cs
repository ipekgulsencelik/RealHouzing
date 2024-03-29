﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RealHouzing.Consume.Models.MapViewModels;

namespace RealHouzing.Consume.ViewComponents.Contact
{
    public class _MapPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _MapPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44345/api/Map");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<MapListViewModel>>(jsonData);

                ViewBag.location = values.Select(x => x.MapLocation).FirstOrDefault();

                return View(values);
            }

            return View();
        }
    }
}