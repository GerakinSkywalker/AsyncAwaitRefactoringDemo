﻿using LetMePutSomeAsyncInIt.Web.Repositories.Interfaces;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LetMePutSomeAsyncInIt.Web.Controllers
{
    [RoutePrefix("albums")]
    public class AlbumController : Controller
    {
        private IAlbumRepository _albumRepo;

        public AlbumController(IAlbumRepository albumRepo)
        {
            _albumRepo = albumRepo;
        }

        [HttpGet]
        [Route("")]
        [Route("index")]
        public async Task<ActionResult> Index()
        {
            var albums = await _albumRepo.GetAll();
            return View(albums);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetByID(int id)
        {
            var album = await _albumRepo.GetByID(id);
            return View(album);
        }
    }
}