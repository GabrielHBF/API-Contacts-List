using DesafioTEcnico.Domain.Entities;
using DesafioTEcnico.Domain.Interfaces;
using MediatR;

namespace DesafioTEcnico.Application.Application.Queryes.Contact
{
    public class GetAllContactQuery : IRequest<List<ContactEntity>>
    {
        public List<ContactEntity>? UsersContacts { get; }

    }

    public class GetAllContactQueryHandle(IContactRepository contactRepository) : IRequestHandler<GetAllContactQuery, List<ContactEntity>>
    {
        private readonly IContactRepository _contactRepository = contactRepository;

        public async Task<List<ContactEntity>> Handle(GetAllContactQuery request, CancellationToken cancellationToken)
        {
            List<ContactEntity> users = await _contactRepository.GetListAsync();
            return users;
    }
    }

}
