using DesafioTEcnico.Domain;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace DesafioTEcnico.Application.Commands
{
    public class CreateUserContactCommand : IRequest<UserContactModel>
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public string UserPhone { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public List<string> Address { get; set; }



    }
}
