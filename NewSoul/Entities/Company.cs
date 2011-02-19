using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
   public class Company : BaseEntity
    {
       public List<User> Users
       {
           get; set;
       }
    }
}
