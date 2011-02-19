using System;
using Common;

namespace Entities
{
    public interface IBaseEntity
    {
        State State { get; set; }
        Guid Id { get; set; }
    }
}