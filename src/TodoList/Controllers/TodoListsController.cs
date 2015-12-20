using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authorization;
using TodoList.Models;

namespace TodoList.Controllers
{
    public class TodoListsController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            ApplicationDbContext db = new ApplicationDbContext();

            var currentUser = db.Users.Where(k => k.Email == User.Identity.Name).FirstOrDefault();
            if (currentUser != null)
            {
                var TodoItems = db.TodoListItems.Where(k => k.ApplicationUserID == currentUser.Id);
                if (TodoItems != null)
                {
                    ViewData["TodoListItems"] = TodoItems;
                }

            }
            else
            {
                return Redirect("/");
            }

            return View();
        }

    }
}
