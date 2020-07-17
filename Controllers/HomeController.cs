using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Work.Domain;
using Work.Domain.Entities;

namespace Work.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {

            return View(dataManager.ItemsIn.GetServiceItems());
        }
        public IActionResult IndexOut()
        {

            return View(dataManager.ItemsOut.GetServiceItems());
        }
    }
}
