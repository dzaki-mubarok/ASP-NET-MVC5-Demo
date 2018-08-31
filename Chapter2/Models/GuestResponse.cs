using System.ComponentModel.DataAnnotations;    //utk error message

namespace Chapter2.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Mohon masukkan nama anda!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Mohon masukkan Email anda!")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="masukkan email anda yg valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mohon masukkan Nomor HP anda!")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Apakah anda akan hadir?")]
        public bool ? Datang { get; set; }
    }
}