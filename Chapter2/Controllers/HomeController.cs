using System;
using System.Web.Mvc;

/// <summary>
/// Chapter 1 _ 
/// </summary>


namespace Chapter2.Controllers
{
    public class HomeController : Controller
    {
        //public string Index(string id, string nama)
        //{
        //    //return "halo . . . ini method string biasa. ini pake .NET MVC versi : ";
        //      return typeof(Controller).Assembly.GetName().Version.ToString();    //menampilkan versi MVC

        //    //kita juga bisa menambahkan nilai langsung dg URL
        //    //return "ID number : " + id + "\n nama : " + nama;   //utk memberi nilai lgsung di url index tambahin ../index/14117652?nama=Dzaki
        //    //atau return "ID number : " + id + "\n nama : " + Request.QueryString[nama];
        //}

            //setiap method dr controller memiliki url acion masing2
        

        //GET: Home/Index
        public ViewResult Index()
        {
            int jam = DateTime.Now.Hour;
            ViewBag.Selamat = jam < 12 ? "Selamat Pagi" : "Selamat Sore";
            return View();
        }

        //GET : Home/FormReservasi
        [HttpGet]
        public ViewResult FormReservasi()
        {
            return View();
        }

        //add overloading dr FormReservasi() utk POST
        [HttpPost]
        public ViewResult FormReservasi(Models.GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                // TODO: Email response to the party organizer
                return View("Thanks", guestResponse);
            }
            else
            {
                // there is a validation error
                return View();
            }

        }
    }
}