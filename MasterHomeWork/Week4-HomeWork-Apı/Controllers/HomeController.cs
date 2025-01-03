using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Week4_HomeWork_Apı.Models;

namespace Week4_HomeWork_Apı.Controllers;

public class HomeController : Controller
{
    private readonly HttpClient _httpClient;
    public HomeController(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient("sametapi");
    }

    public async Task<IActionResult> Index()
    {
        HttpResponseMessage responseMessage = await _httpClient.GetAsync("products?limit=9");
        string response = await responseMessage.Content.ReadAsStringAsync();
        ApiResponse? apiResponse = JsonConvert.DeserializeObject<ApiResponse>(response);

        List<Product> products = apiResponse.Products;
        return View(products);
    }


    [HttpGet]
    public async Task<IActionResult> Details(int id)
    {
        var responseMessage = await _httpClient.GetAsync($"products/{id}");
        var contentResponse = await responseMessage.Content.ReadAsStringAsync();
        
        ApiResponse? apiResponse = JsonConvert.DeserializeObject<ApiResponse>(contentResponse);

        var product = apiResponse.Product;
        return View(product);
    }

    public async Task<IActionResult> AddProduct()
    {
        var responseMessage = await _httpClient.GetAsync("products/category");

        if (!responseMessage.IsSuccessStatusCode)
        {
            throw new Exception("Kategori verileri alınamadı.");
        }

        var contentResponse = await responseMessage.Content.ReadAsStringAsync();



        var categories = JsonConvert.DeserializeObject<CategoryResponse>(contentResponse);


        // var categories = JsonConvert.DeserializeObject<List<string>>(contentResponse);
        ViewBag.Categories = categories.Categories;
        return View();
    }




}
