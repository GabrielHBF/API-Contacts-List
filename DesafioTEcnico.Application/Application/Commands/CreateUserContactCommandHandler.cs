using DesafioTEcnico.Domain;
using MediatR;
using DesafioTEcnico.Application.interfaces;
using System.ComponentModel.DataAnnotations;

namespace DesafioTEcnico.Application.Commands
{
    public class CreateUserContactCommandHandler : IRequestHandler<CreateUserContactCommand, UserContactModel>
    {
        private readonly InterfaceUserContatctBD _interfaceRepository;
        public CreateUserContactCommandHandler(InterfaceUserContatctBD interfaceRepository)
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
