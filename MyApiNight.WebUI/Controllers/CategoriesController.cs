using Microsoft.AspNetCore.Mvc;
using MyApiNight.WebUI.Dtos;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MyApiNight.WebUI.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoriesController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> CategoryList()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7032/api/Category");
            if (responseMessage.IsSuccessStatusCode)
            { 
                var jsondata=await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsondata);
                return View(values);
            }
            return View();
        }
    }
}
