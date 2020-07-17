using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Work.Service;
using Work.Controllers;
using Work.Domain;
using Work.Domain.Entities;
using System.Linq;

namespace Work.Controllers
{
    
    public class ServiceItemsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public ServiceItemsController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.ItemsIn.GetServiceItemById(id));
            }

            return View(dataManager.ItemsIn.GetServiceItems());
        }


        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new ServiceItem() : dataManager.ItemsIn.GetServiceItemById(id);

            return View(entity);
        }
        public IActionResult EditOut(Guid id)
        {
            var entity = id == default ? new ServiceItem() : dataManager.ItemsOut.GetServiceItemById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(ServiceItem model)
        {
            if (ModelState.IsValid)
            {
                model.Type = true; 
                dataManager.ItemsIn.SaveServiceItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);

        }
        [HttpPost]
        public IActionResult EditOut(ServiceItem model)
        {
            if (ModelState.IsValid)
            {
                model.Type = false;
                dataManager.ItemsOut.SaveServiceItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.ItemsIn.DeleteServiceItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
        [HttpPost]
        public IActionResult DeleteOut(Guid id)
        {
            dataManager.ItemsOut.DeleteServiceItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}