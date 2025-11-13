using DesafioTEcnico.Domain;
using MediatR;

namespace DesafioTEcnico.Application.Queryes
{
    public class GetUserContactByIdQuery : IRequest <UserContactModel>
    {
            public string UserId { get; set; }

    }

        public class GetUserContactByIdQueryHandler : IRequestHandler<GetUserContactByIdQuery, UserContactModel>
        {
        private readonly InterfaceRepository _interfaceRepository;

        public GetUserContactByIdQueryHandler(InterfaceRepository interfaceRepository)
            {
                this._interfaceRepository = interfaceRepository;
            }

            public async Task<UserContactModel> Handle(GetUserContactByIdQuery request, CancellationToken cancellationToken)
            {
                var user = await _interfaceRepository.getContactById(request.UserId);
                return user;
            }

    }

    }

