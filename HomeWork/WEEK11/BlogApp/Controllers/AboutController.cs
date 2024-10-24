using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class AboutController : Controller
    {
        List<AboutModel> aboutModels;
        public AboutController()
        {
            aboutModels = [
                new AboutModel { AdSoyad="Samet Önür", Aciklama="Merhaba ben Samet Önür 2000 doğumluyum Düzce ünviersitesi Bilgisayar Programcılığı mezunuyuyum. Kendimi bu alanda geliştirmek için Acunmedya Akademide Back-End Uzmanlık eğitimi alıyorum." , Link="https://github.com/Sameetonur" , StajYer="Monster Bilgisayar A.Ş", Resim="/resimlerim/resim1.jpg"  },
            ];

        }
        public ActionResult Index()
        {
            ViewBag.AboutList=aboutModels;
            return View();
        }

    }
}
