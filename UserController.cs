using lab6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab6.Controllers
{
    public class UserController : Controller
    {
        // Статичний список користувачів для прикладу
        private static List<User> users = new List<User>
        {
            new User { Id = 1, FirstName = "Alex", LastName = "Miller", Email = "alex@example.com", RegistrationDate = DateTime.Now.AddDays(-10) },
            new User { Id = 2, FirstName = "Shanel", LastName = "Davis", Email = "shanel@example.com", RegistrationDate = DateTime.Now.AddDays(-5) },
            new User { Id = 3, FirstName = "Pall", LastName = "Garcia", Email = "pall@example.com", RegistrationDate = DateTime.Now.AddDays(-1) }
        };

        // Метод для відображення списку користувачів
        public ActionResult Index()
        {
            return View(users);
        }

        // Метод для відображення докладної інформації про користувача
        public ActionResult Details(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }
    }
}
