using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using RedRocket.Utilities.Core.Validation;

namespace RedRocket
{
    public static class ValidationExtensions
    {
        public static bool IsObjectValid<T>(this T entity)
        {
            return !GetValidationErrors(entity).Any();
        }

        public static IEnumerable<ObjectValidationError> GetValidationErrors<T>(this T entity)
        {
            var entityType = entity.GetType();
            var entityInterfaces = entityType.GetInterfaces();

            return from interfaces in entityInterfaces
                   from prop in interfaces.GetProperties()
                   let propVal = prop.GetValue(entity, null)
                   from attr in prop.GetCustomAttributes(typeof(ValidationAttribute), true).Cast<ValidationAttribute>().Where(attr => !attr.IsValid(propVal))
                   select new ObjectValidationError
                   {
                       Message = attr.FormatErrorMessage(prop.Name),
                       PropertyName = prop.Name
                   };
        }
    }
}