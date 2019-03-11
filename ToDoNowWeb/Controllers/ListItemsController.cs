using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoNowWeb.Entities;
using ToDoNowWeb.Models;

namespace ToDoNowWeb.Controllers
{
    public class ListItemsController : Controller
    {
        // GET: ListItems
        public ActionResult Index()
        {
            ListItemViewModel[] listItems = new ListItemViewModel[2];
            listItems[0] = new ListItemViewModel();
            listItems[0].Id = 12;
            listItems[0].ItemText = "Buy apples.";

            listItems[1] = new ListItemViewModel();
            listItems[1].Id = 15;
            listItems[1].ItemText = "Buy organges.";

            return View(listItems);
        }

        // GET: ListItems/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ListItems/Create
        public ActionResult Create()
        {
            AddEditListItemViewModel model = new AddEditListItemViewModel();

            return View(model);
        }

        // POST: ListItems/Create
        [HttpPost]
        public ActionResult Create(AddEditListItemViewModel model)
        {
            //try
            //{
                // TODO: Add insert logic here
                DataAccess data = new DataAccess();
                ListItem listItem = new ListItem(model.ItemText);

                data.AddListItem(listItem);
                                 

                return RedirectToAction("Index");
            //}
            //catch
            //{
                //return View();
            //}
        }

        // GET: ListItems/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ListItems/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ListItems/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ListItems/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
