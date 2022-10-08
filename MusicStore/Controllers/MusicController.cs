using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class MusicController : Controller
    {
        // GET: Music
        public ActionResult Random()
        {
            var song = new Song() { name = "This Fffire" };


            return View(song);


        }



        public ActionResult Edit(int id)
        {
            return Content("1");
        }


        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (pageIndex.HasValue) pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy)) sortBy = "Name";

            return Content(String.Format("Page index={0} & sortBy={1}", pageIndex, sortBy));
        }

    }


}