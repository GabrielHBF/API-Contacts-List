using DesafioTEcnico.Application.interfaces;
using DesafioTEcnico.Domain;
using MediatR;

namespace DesafioTEcnico.Application.Queryes
{
    public class getUserContactByIdQuery : IRequest <UserContactModel>
    {
            public string UserId { get; set; }

    }

        public class getUserContactByIdQueryHandler : IRequestHandler<getUserContactByIdQuery, UserContactModel>
        {
        private readonly InterfaceUserContatctBD _interfaceRepository;

        public getUserContactByIdQueryHandler(InterfaceUserContatctBD interfaceRepository)
            {
                this._interfaceRepository = interfaceRepository;
            }

            public async Task<UserContactModel> Handle(getUserContactByIdQuery request, CancellationToken cancellationToken)
            {
                var user = await _interfaceRepository.getContactById(request.UserId);
                return user;
            }

    }

    }

