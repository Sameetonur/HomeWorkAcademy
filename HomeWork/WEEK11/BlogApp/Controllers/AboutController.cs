using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class AboutController : Controller
    {

        // public AboutController()
        // {
        //     aboutModels = [
        //         new AboutModel { AdSoyad="Samet Önür", Aciklama="Merhaba ben Samet Önür 2000 doğumluyum Düzce ünviersitesi Bilgisayar Programcılığı mezunuyuyum. Kendimi bu alanda geliştirmek için Acunmedya Akademide Back-End Uzmanlık eğitimi alıyorum." , Link="https://github.com/Sameetonur" , StajYer="Monster Bilgisayar A.Ş", Resim="/resimlerim/resim1.jpg"  },

        //     ];

        // }
        public ActionResult Index()
        {
            AboutModel about = new AboutModel { AdSoyad = "Samet Önür", Aciklama = "Merhaba ben Samet Önür 2000 doğumluyum Düzce ünviersitesi Bilgisayar Programcılığı mezunuyuyum. Kendimi bu alanda geliştirmek için Acunmedya Akademide Back-End Uzmanlık eğitimi alıyorum.", Resim = "/resimlerim/resim1.jpg" };

            List<LinkModel> links = new List<LinkModel>();

            links.Add(new LinkModel
            {
                LinkName = "Github",
                LinkUrl = "https://github.com/Sameetonur"
            });
            links.Add(new LinkModel
            {
                LinkName = "Linkedin",
                LinkUrl = "https://www.linkedin.com/in/sameetonr/"
            });

            about.Links = links;

            StajYer stajs = new StajYer { StajName = "Google A.Ş" };

            List<StajYer> stajYers = new List<StajYer>();

            stajYers.Add(stajs);
            stajYers.Add(new StajYer { StajName = "Apple A.Ş" });
            stajYers.Add(new StajYer { StajName = "Monster A.Ş" });

            about.Staj = stajYers;


            return View(about);

        }

    }
}
