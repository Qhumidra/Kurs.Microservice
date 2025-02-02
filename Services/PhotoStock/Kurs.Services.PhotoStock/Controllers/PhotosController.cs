﻿using Kurs.Services.PhotoStock.Dtos;
using Kurs.Shared.ControllerBases;
using Kurs.Shared.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Matching;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Kurs.Services.PhotoStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotosController : CustomBaseController
    {
        [HttpPost]
        public async Task<IActionResult> PhotoSave(IFormFile photo, CancellationToken cancellationToken)
        {
            if (photo != null && photo.Length > 0)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/photos", photo.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await photo.CopyToAsync(stream, cancellationToken);
                }

                var returnPath = photo.FileName;

                PhotoDto photoDto = new() { Url = returnPath };

                return CreateActionResultInstance(Response<PhotoDto>.Success(photoDto, 200));
            }

            return CreateActionResultInstance(Response<PhotoDto>.Fail("photo is empty", 400));
        }

        [HttpDelete]
        public IActionResult PhotoDelete(string photoUrl)
        {

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/photos", photoUrl);

            if (!System.IO.File.Exists(path))
                return CreateActionResultInstance(Response<PhotoDto>.Fail("photo not found", 400));


            System.IO.File.Delete(path);

            return CreateActionResultInstance(Response<NoContent>.Success(204));
        }
    }
}
