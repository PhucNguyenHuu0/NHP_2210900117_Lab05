using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab05.Models;

namespace lab05.Controllers
{
    public class NHPSongController : Controller
    {
        private static List<NHPSong> NHPSongs = new List<NHPSong>()
        {
            new NHPSong{id=221,nhpTitle = "Nguyen Huu Phuc",nhpAuthor = "K22CNT1,",nhpArtist="Phuc Phuc",nhpYaerRelease=2024},
            new NHPSong{id=2222,nhpTitle = "Nguyen Tien Loc",nhpAuthor = "K22CNT1,",nhpArtist="Loc",nhpYaerRelease=2024},
        };
        // GET: NHPSong
        public ActionResult Index()
        {
            return View(NHPSongs);
        }
        // get: create song
        public ActionResult NHPCreate()
        {
            var NHPSong = new NHPSong();

            return View(NHPSong);
        }
        // Post: create song
        [HttpPost]
        public ActionResult NHPCreate(NHPSong NHPSong)
        {
            if (!ModelState.IsValid) // neu loi xay ra
            {
                return View(NHPSong);
            }
            // neu du lieu dung -> luu du lieu vao danh sach bai hat
            NHPSongs.Add(NHPSong);
            return RedirectToAction("index");
        }
    }
}