using DesafioTEcnico.Domain.Entities;
using MediatR;

namespace DesafioTEcnico.Application.Application.Commands.Contact
{
    public class DeleteContactCommand : IRequest<ContactEntity>
    {
        public required string Id { get; set; }
    }
}
