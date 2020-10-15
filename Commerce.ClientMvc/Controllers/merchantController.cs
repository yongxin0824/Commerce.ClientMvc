using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Commerce.ClientMvc.Controllers
{
    public class merchantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}