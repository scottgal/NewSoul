using System;
using System.ComponentModel.DataAnnotations;
using Common.Model;

namespace ViewObjects
{
    public interface IBaseViewObject
    {
        ModelState State { get; set; }
        Guid ID { get; set; }
    }

    public class BaseViewObject : IBaseViewObject
    {
        private ModelState _state = new ModelState();

        [Required]
        public Guid ID { get; set; }

     
        public ModelState State
        {
            get { return _state; }
            set { _state = value; }
        }

    }
}