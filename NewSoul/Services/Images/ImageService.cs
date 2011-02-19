using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using ViewObjects.Images;

namespace Services.Images
{
   public class ImageService
   {

       private readonly IImageRepository _imageRepository;
       public ImageService(IImageRepository imageRepository)
       {
           _imageRepository = imageRepository;
       }

       public void Create(ImageViewObject image)
       {
           ValidationService.Validate(image);
          var imageEntity=Mapper.Map<ViewObjects.Images.ImageViewObject, Entities.Image>(image);
       }
    }
}
