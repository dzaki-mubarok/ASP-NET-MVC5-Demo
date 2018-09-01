using System;
using System.Web.Mvc;

/// <summary>
/// Chapter 1 _ 1. bikin index action method beserta view nya.(panggil viewbag.selamat di view)
/// 2. Designing a Data Model (for storing, validating, and confirming dari FormReservasi)  - GuestResponse.cs
/// 3. bikin action link ke FormReservasi
/// 4. bikin FormReservasi action method beserta view nya arahkan modelclass di viewnya ke GuestResponse
/// 5. bikin form reservasinya kemudian Add an Action Method to Support POST Requests in the HomeController.cs [httpget] [httpPost]
/// 6. bikin new view thanks.cshtml
/// 7. adding Validation in the GuestResponse.cs errormessage juga di post homecontroller nya
/// 8. adding Html.ValidationSummary Helper Method di FormReservasi
/// 9. buat style.css utk style error nya
/// 10. add bootstrap dan ubah style view2 nya
/// 11. add WebMail Helper in the Thanks.cshtml 
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

            //setiap method dr controller memiliki url action masing2
        

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
            //Checking for Form Validation Errors
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