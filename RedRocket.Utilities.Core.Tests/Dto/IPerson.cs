using System.ComponentModel.DataAnnotations;
using FlitBit.Dto;

namespace RedRocket.Utilities.Core.Tests.Dto
{
    [DTO]
    public interface IPerson
    {
        [Required, StringLength(150, MinimumLength = 3)]
        string FirstName { get; set; }

        [Required, MaxLength(7)]
        string LastName { get; set; }

        [Required, Range(1, 115)]
        int Age { get; set; }
    }
}