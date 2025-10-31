using DesafioTEcnico.Data;
using DesafioTEcnico.Models;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DesafioTEcnico.Application.Commands
{
    public class UpdateUserContactCommandHandle : IRequestHandler<UpdateUserContactAtributeCommand, UserContactModel>
    {
        private readonly MongoBD _mongoBD;
        public UpdateUserContactCommandHandle(MongoBD mongoBD)
        {
            _mongoBD = mongoBD;
        }
        public async Task<UserContactModel> Handle(UpdateUserContactAtributeCommand request, CancellationToken cancellationToken)
        {
            var updateUserContact = new UserContactModel
            {
                Id = request.id,
                Email = request.UserEmail,
                Phone = request.UserPhone,
                Address = request.Address,
                BirthDate = request.BirthDate,
            };

            await _mongoBD.upadateContactById(request.id, updateUserContact);
            return updateUserContact;
        }
    }
}
