using L.P.Discography.Data;
using L.P.Discography.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace L.P.Discography.Controllers
{
    public class AlbumsController : Controller
    {
        private AlbumsRepository _albumsRepository = null;

        public AlbumsController()
        {
            _albumsRepository = new AlbumsRepository();

        }

        public ActionResult Index()
        {
            var albums = _albumsRepository.GetAlbums();
            return View(albums);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var album = _albumsRepository.GetAlbum((int)id);
            return View(album);
        }
    }
}