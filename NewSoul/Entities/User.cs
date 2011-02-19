using System;
using System.Collections.Generic;

namespace Entities
{
    public class User : BaseEntity
    {


        public string DisplayName { get; set; }
        public bool Active { get; set; }

        public List<Role> Roles
        {
            get;
            set;
        }

        public Profile Profile { get; set; }
        }
    }

