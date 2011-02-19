using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
namespace Services.Mappings
{
    public static class AutomapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Entities.Image, ViewObjects.Images.ImageViewObject>();


        }
    }
}



