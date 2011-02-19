using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Common.Model
{
    public class ModelState
    {
        public ModelStateEnum CurrentState
        {
            get; set;
        }

        public List<ValidationResult> Messages { get; set; }
    }
}
