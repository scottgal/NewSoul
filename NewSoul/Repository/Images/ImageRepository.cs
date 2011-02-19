using System;
using System.Collections.Generic;
using Entities;
using Entities.Configuration;
using System.Linq;
using Services.Images;

namespace Repository.Images
{


    public class ImageRepository : IImageRepository
    {


        public Image Create(Image image)
        {
            using(var db = new NewSoulContext())
            {
                db.Images.Add(image);
                db.ChangeTracker.DetectChanges();
                db.SaveChanges();
            }
            return image; }

        public void Update(Image image)
        {
            using(var db = new NewSoulContext())
            {
                db.Images.Attach(image);
                db.ChangeTracker.DetectChanges();
                db.SaveChanges();

            }
        }

        public void Delete(Image image)
        {
            using (var db = new NewSoulContext())
            {
                db.Images.Attach(image);
                db.ChangeTracker.DetectChanges();
                db.Images.Remove(image);
                db.SaveChanges();
            }
        }

        public Image Get(Guid imageId)
        {

          using (var db = new NewSoulContext())
          { 
              return db.Images.Where(x => x.Id == imageId).FirstOrDefault();
          }
           
        
        }

        public List<Image> GetList(Func<Image, bool> searchCriteria, Func<Image, object > orderCriteria,  int count, int pageNumber)
        {
          using(var db = new NewSoulContext())
          {
              var resultList = db.Images.Where(searchCriteria).OrderBy(orderCriteria).Skip(pageNumber -1 * count).Take(count).ToList();
              return resultList;
          }
           
        }

        public List<Image> GetList(Func<Image, bool> searchCriteria)
        {
            using (var db = new NewSoulContext())
            {
                var resultList = db.Images.Where(searchCriteria).ToList();
                return resultList;
            }

        }
    }
}