using System;
using Microsoft.AspNetCore.Mvc;
using Northwind_Traders.Models;
using System.Linq;

namespace Northwind_Traders.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() => View();
    }
}