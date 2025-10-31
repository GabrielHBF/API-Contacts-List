using DesafioTEcnico.Data;
using DesafioTEcnico.Models;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using ZstdSharp;

namespace DesafioTEcnico.Application.Commands
{
    public class CreateUserContactCommandHandler : IRequestHandler<CreateUserContactCommand, UserContactModel>
    {
        private readonly MongoBD _mongoBD;
        public CreateUserContactCommandHandler(MongoBD mongoBD)
        {
            _mongoBD = mongoBD;
        }
        public async Task<UserContactModel> Handle(CreateUserContactCommand request, CancellationToken cancellationToken)
        {
             var contactUser = new UserContactModel();

             contactUser.Name = request.UserName;
             contactUser.Phone = request.UserPhone;
             contactUser.Email = request.UserEmail;
             contactUser.Address = request.Address;

             await _mongoBD.createContactUser(contactUser);
             return contactUser;
         

        }
    }

}
