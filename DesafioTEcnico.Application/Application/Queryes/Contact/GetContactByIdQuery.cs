using DesafioTEcnico.Domain.Entities;
using DesafioTEcnico.Domain.Interfaces;
using MediatR;

namespace DesafioTEcnico.Application.Application.Queryes.Contact
{
    public class GetContactByIdQuery : IRequest <ContactEntity>
    {
            public string? ContactId { get; set; }
    }

        public class GetContactByIdQueryHandler(IContactRepository contactRepository) : IRequestHandler<GetContactByIdQuery, ContactEntity>
        {
        private readonly IContactRepository _contactRepository = contactRepository;

        public async Task<ContactEntity> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
            {
                var user = await _contactRepository.GetByIdAsync(request.ContactId);
                return user;
            }

    }

    }

