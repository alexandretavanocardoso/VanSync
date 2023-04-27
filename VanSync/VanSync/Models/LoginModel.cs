namespace VanSync.Models
{
    public class LoginModel
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
    }
}
