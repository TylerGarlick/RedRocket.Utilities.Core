using System;
using System.Collections.Generic;

namespace RedRocket.Utilities.Core.Validation
{
    public class ObjectValidationException : Exception
    {
        public IEnumerable<ObjectValidationError> Errors { get; set; }

        public ObjectValidationException(IEnumerable<ObjectValidationError> errors)
        {
            Errors = errors;
        }
    }
}