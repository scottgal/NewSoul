using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Common;
using Common.Model;
using ViewObjects;

namespace Services
{
    public class ValidationService
    {
        public static bool IsValid<T>(T viewObject) where T : IBaseViewObject
        {
            var validationResults = new List<ValidationResult>();
            if (Validator.TryValidateObject(viewObject, new ValidationContext(viewObject, null, null),validationResults))
            {
                viewObject.State.CurrentState = ModelStateEnum.Valid;
 
                return true;
            }

            viewObject.State.CurrentState = ModelStateEnum.Invalid;
            return false;
        }
    }
}