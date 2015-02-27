using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Music.Models;

namespace Music.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        MusicStoreentities storeDB = new MusicStoreentities();

        public ActionResult Index()
             {
                 var genres = storeDB.Genres.ToList();
                 return View(genres);
             }

        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album " + id };
            return View(album);
        }

        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre { Name = genre };
            return View(genreModel);
        }
    }
}
