using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDo.Models;

namespace ToDo.Controllers
{
    public class TaskController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

       
    }
}