using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class CategoryController : Controller
    {
        List<CategoryModel> categoryModels;
        public CategoryController()
        {
            categoryModels = [
                new CategoryModel {
                    Kategory="HAYVANLAR"
                },
                new CategoryModel {
                    Kategory="DOĞA"
                },
                new CategoryModel {
                    Kategory="BİNALAR"
                },
            ];

        }

        public ActionResult Index()
        {

            ViewBag.CategoryList=categoryModels;
            return View();
        }

    }
}
