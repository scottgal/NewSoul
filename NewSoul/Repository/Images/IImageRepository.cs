using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using Entities;
using Repository.Interfaces;

namespace Services.Images
{
    public interface IImageRepository : IEntityRepository<Image>
    {
    }
}
