using System;
using shopping.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using shopping.ViewModels;

namespace shopping.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index (){
            
            return View();
        }

        public IActionResult Login(string username, string password) {

            String result = "login successful";

            if (username == null || "".Equals(username) || password == null || "".Equals(password)) {
                result = "login fail";
            }
            
            return Content(result);
        }
        public IActionResult ShowUserList()
        {
            List<User> userList = new List<User>()
            {
                new User(0, "Name 0", "name000", "12345678","name000@gmail.com"),
                new User(1, "Name 1", "name001", "12345678","name001@gmail.com"),
                new User(2, "Name 2", "name002", "12345678","name002@gmail.com"),
                new User(3, "Name 3", "name003", "12345678","name003@gmail.com"),
                new User(4, "Name 4", "name004", "12345678","name004@gmail.com"),
            };

            var viewModels = new UserList()
            {
                users = userList
            };
            
            return View(viewModels);
        }

    }
}
