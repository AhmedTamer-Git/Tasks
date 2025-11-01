using System.ComponentModel.DataAnnotations;

namespace D2_MVC_Task.ViewModels
{
    // Login ViewModel
    public class LoginVM
    {
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}