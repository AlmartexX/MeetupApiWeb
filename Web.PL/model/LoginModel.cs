using System.ComponentModel.DataAnnotations;

namespace Web.PL.model
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password Required")]
        public string Password { get; set; }
    }
}
