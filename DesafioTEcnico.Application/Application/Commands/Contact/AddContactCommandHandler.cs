using MediatR;
using DesafioTEcnico.Domain.Interfaces;
using DesafioTEcnico.Domain.Entities;

namespace DesafioTEcnico.Application.Application.Commands.Contact
{
    public class AddContactCommandHandler(IContactRepository contactRepository) : IRequestHandler<AddContactCommand, ContactEntity>
    {
        private readonly IContactRepository _contactRepository = contactRepository;

        public async Task<ContactEntity> Handle(AddContactCommand request, CancellationToken cancellationToken)
        {
            var contactUser = new ContactEntity
            {
                Name = request.ContactName,
                Phone = request.ContactPhone,
                Email = request.ContactEmail,
                Address = request.Address
            };
            await _contactRepository.CreateAsync(contactUser);
            return contactUser;
         
        }
    }

}
