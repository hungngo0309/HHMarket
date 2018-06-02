using System;
namespace shopping.Models
{

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public User(int id, string name, string username, string password, string email)
        {
            this.Username  = username;
            this.Password = password;
            this.Email = email;
            this.Name = name;
            this.Id = id;
        }
    }
}
