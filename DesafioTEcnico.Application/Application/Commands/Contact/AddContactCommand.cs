using DesafioTEcnico.Domain.Entities;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace DesafioTEcnico.Application.Application.Commands.Contact
{
    public class AddContactCommand : IRequest<ContactEntity>
    {
        [Required]
        public string? ContactName { get; set; }
        [Required]
        public string? ContactEmail { get; set; }
        [Required]
        public string? ContactPhone { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public List<string>? Address { get; set; }



    }
}
