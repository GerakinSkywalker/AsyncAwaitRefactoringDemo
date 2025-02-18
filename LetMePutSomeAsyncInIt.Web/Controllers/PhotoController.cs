﻿using LetMePutSomeAsyncInIt.Web.Repositories.Interfaces;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LetMePutSomeAsyncInIt.Web.Controllers
{
    [RoutePrefix("Photo")]
    public class PhotoController : Controller
    {
        private IPhotoRepository _photoRepo;

        public PhotoController(IPhotoRepository photoRepo)
        {
            _photoRepo = photoRepo;
        }

        [HttpGet]
        [Route("")]
        [Route("index")]
        public async Task<ActionResult> Index()
        {
            var allPhotos = await _photoRepo.GetAll();
            return View(allPhotos);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetByID(int id)
        {
            var photo = await _photoRepo.GetByID(id);
            return View(photo);
        }
    }
}