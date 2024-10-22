using System.Reflection.Metadata;
using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class BlogController : Controller
    {
        List<BlogModel> blogModeList;

        public BlogController()
        {
            blogModeList = [

                new BlogModel
                {
                    Id=1, Aciklama="Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.", Baslik="TATLI KÖPÜŞLER", Resim="https://picsum.photos/id/237/200/300"
                },
                new BlogModel
                {
                    Id=2, Aciklama="Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.", Baslik="KOCAMAN BİNALAR", Resim="https://picsum.photos/id/238/200/300"
                },
                new BlogModel
                {
                    Id=3, Aciklama="Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.", Baslik="PÜF ÇİÇEĞİ", Resim="https://picsum.photos/id/239/200/300"
                },
                new BlogModel
                {
                    Id=4, Aciklama="Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.", Baslik=" KURAK DAĞLAR ", Resim="https://picsum.photos/id/247/200/300"
                },
                new BlogModel
                {
                    Id=5, Aciklama="Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.", Baslik="GÜZEL MANZARA", Resim="https://picsum.photos/id/257/200/300"
                },
                new BlogModel
                {
                    Id=6, Aciklama="Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.", Baslik="SEL BASKINI", Resim="https://picsum.photos/id/267/200/300"
                },
                new BlogModel
                {
                    Id=7, Aciklama="Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.", Baslik="OVALARIN GÜZELLİKLERİ", Resim="https://picsum.photos/id/277/200/300"
                },
                new BlogModel
                {
                    Id=8, Aciklama="Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.", Baslik="MUAZZAM DAĞLAR", Resim="https://picsum.photos/id/287/200/300"
                },
                new BlogModel
                {
                    Id=9, Aciklama="Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.", Baslik="KİRLİ FABRİKALAR", Resim="https://picsum.photos/id/297/200/300"
                },
                new BlogModel
                {
                    Id=10, Aciklama="Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.", Baslik="VERİMLİ TARLALAR", Resim="https://picsum.photos/id/337/200/300"
                },
                new BlogModel
                {
                    Id=11, Aciklama="Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.", Baslik="TATLI BİR CAFE", Resim="https://picsum.photos/id/437/200/300"
                },
                new BlogModel
                {
                    Id=12, Aciklama="Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.", Baslik="UZAYIN DERİNLİKLERİ", Resim="https://picsum.photos/id/537/200/300"
                },


            ];

        }
        public ActionResult Index()
        {

            ViewData["BlogModelList"] = blogModeList;
            return View();
        }

    }
}
