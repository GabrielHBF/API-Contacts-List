using DesafioTEcnico.Domain.Entities;
using DesafioTEcnico.Domain.Interfaces;
using MediatR;

namespace DesafioTEcnico.Application.Application.Commands.Contact
{
    public class UpdateContactAtributeCommandHandle(IContactRepository contactRepository) : IRequestHandler<UpdateContactAtributeCommand, ContactEntity>
    {
        private readonly IContactRepository _contactRepository = contactRepository;

        public async Task<ContactEntity> Handle(UpdateContactAtributeCommand request, CancellationToken cancellationToken)
        {
           var updateContact = await _contactRepository.GetByIdAsync(request.Id);

            if(updateContact == null)
            {
                return null;
            }
  
            if (!string.IsNullOrEmpty(request.ContactName) && request.ContactName != "string")
            {
                updateContact.Name = request.ContactName;
            }
            if (request.Address != null && request.Address.Count > 0 && request.Address[0] != "string")
            {
                updateContact.Address = request.Address;
            }
            if (!string.IsNullOrEmpty(request.ContactEmail) && request.ContactEmail != "string")
            {
                updateContact.Email = request.ContactEmail;
            }
            if (request.BirthDate != null)
            {
                updateContact.BirthDate = request.BirthDate;
            }
            if (!string.IsNullOrEmpty(request.ContactPhone) && request.ContactPhone != "string")
            {
                updateContact.Phone = request.ContactPhone;
            }

            await _contactRepository.UpdateAsync(request.Id, updateContact);
            return updateContact;
        }
    }
}
