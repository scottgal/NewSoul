using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace Entities
{
    public class BaseEntity : IBaseEntity
    {
        public State State { get; set; }

        public Guid Id { get; set; }
    }
}
