using DesafioTEcnico.Domain.Entities;
using MediatR;

namespace DesafioTEcnico.Application.Application.Commands.Contact
{
    public class UpdateContactAtributeCommand : IRequest<ContactEntity>
    {
        public string? Id {  get; set; }
        public string? ContactName { get; set; }
        public string? ContactEmail { get; set; }
        public string? ContactPhone { get; set; }
        public DateTime BirthDate { get; set; }
        public List<string>? Address { get; set; }

    }
}
