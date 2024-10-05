using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LAB1.Pages
{
    public class Zadanie2Model : PageModel
    {
        public UserModel UserData { get; set; } = new UserModel();
        public bool ShowData { get; set; } = false;

        public void OnPost(string name, string email, string message)
        {
            // Przypisujemy dane użytkownika do obiektu modelu
            UserData.Name = name;
            UserData.Email = email;
            UserData.Message = message;

            // Ustawiamy flagę, żeby dane były widoczne w widoku po przesłaniu
            ShowData = true;
        }
    }

    public class UserModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}