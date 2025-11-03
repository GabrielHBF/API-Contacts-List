using DesafioTEcnico.Application.interfaces;
using DesafioTEcnico.Domain;
using MediatR;

namespace DesafioTEcnico.Application.Queryes
{
    public class getAllUserContactQuery : IRequest<List<UserContactModel>>
    {
        public List<UserContactModel> usersContacts { get; }

    }

    public class getAllUserContactQueryHandle : IRequestHandler<getAllUserContactQuery, List<UserContactModel>>
    {
        private readonly InterfaceUserContatctBD _interfaceRepository;

        public getAllUserContactQueryHandle(InterfaceUserContatctBD interfaceRepository)
        {
           this._interfaceRepository = interfaceRepository;
        }

        public async Task<List<UserContactModel>> Handle(getAllUserContactQuery request, CancellationToken cancellationToken)
        {
            List<UserContactModel> users = await _interfaceRepository.getListContact();
            return users;
    }
    }

}
