using DesafioTEcnico.Domain;
using MediatR;

namespace DesafioTEcnico.Application.Queryes
{
    public class GetAllUserContactQuery : IRequest<List<UserContactModel>>
    {
        public List<UserContactModel> usersContacts { get; }

    }

    public class GetAllUserContactQueryHandle : IRequestHandler<GetAllUserContactQuery, List<UserContactModel>>
    {
        private readonly InterfaceRepository _interfaceRepository;

        public GetAllUserContactQueryHandle(InterfaceRepository interfaceRepository)
        {
           this._interfaceRepository = interfaceRepository;
        }

        public async Task<List<UserContactModel>> Handle(GetAllUserContactQuery request, CancellationToken cancellationToken)
        {
            List<UserContactModel> users = await _interfaceRepository.getListContact();
            return users;
    }
    }

}
