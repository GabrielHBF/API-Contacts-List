using DesafioTEcnico.Domain.Entities;
using DesafioTEcnico.Domain.Interfaces;
using MediatR;

namespace DesafioTEcnico.Application.Application.Commands.Contact;
public class UpdateContactCommandHandle(IContactRepository contactRepository) : IRequestHandler<UpdateContactCommand, ContactEntity>
{
    private readonly IContactRepository _contactRepository = contactRepository;

    public async Task<ContactEntity> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
    {
        var updateUserContact = new ContactEntity
        {
            Id = request.Id,
            Name = request.ContactName,
            Email = request.ContactEmail,
            Phone = request.ContactPhone,
            Address = request.Address,
            BirthDate = request.BirthDate,
        };
        await _contactRepository.UpdateAsync(request.Id, updateUserContact);
        return updateUserContact;
    }
}
