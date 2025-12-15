using DesafioTEcnico.Domain.Entities;
using DesafioTEcnico.Domain.Interfaces;
using MediatR;

namespace DesafioTEcnico.Application.Application.Commands.Contact
{
    public class DeleteContactCommandHandler(IContactRepository contactRepository) : IRequestHandler<DeleteContactCommand, ContactEntity>
    {
        private readonly IContactRepository _contactRepository = contactRepository;
        async Task<ContactEntity> IRequestHandler<DeleteContactCommand, ContactEntity>.Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
            var contactDelete = await _contactRepository.DeleteAsync(request.Id);
            return contactDelete;

        }        
       
    }
}
