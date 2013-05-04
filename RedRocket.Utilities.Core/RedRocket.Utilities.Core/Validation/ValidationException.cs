using System;
using System.Collections.Generic;

namespace RedRocket.Utilities.Core.Validation
{
    public class ValidationException : Exception
    {
        public IEnumerable<ObjectValidationError> Errors { get; set; }

        public ValidationException(IEnumerable<ObjectValidationError> errors)
        {
            Errors = errors;
        }
    }
}