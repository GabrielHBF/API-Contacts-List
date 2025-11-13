using MediatR;
using DesafioTEcnico.Domain;

namespace DesafioTEcnico.Application.Commands
{
    public class CreateUserContactCommandHandler : IRequestHandler<CreateUserContactCommand, UserContactModel>
    {
        private readonly InterfaceRepository _interfaceRepository;
        public CreateUserContactCommandHandler(InterfaceRepository interfaceRepository)
        {
            _interfaceRepository = interfaceRepository;
        }
        public async Task<UserContactModel> Handle(CreateUserContactCommand request, CancellationToken cancellationToken)
        {
             var contactUser = new UserContactModel();

             contactUser.Name = request.UserName;
             contactUser.Phone = request.UserPhone;
             contactUser.Email = request.UserEmail;
             contactUser.Address = request.Address;

             await _interfaceRepository.createContactUser(contactUser);
             return contactUser;
         
        }
    }

}
