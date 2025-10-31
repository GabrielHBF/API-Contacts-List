using DesafioTEcnico.Data;
using DesafioTEcnico.Models;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DesafioTEcnico.Application.Commands
{
    public class UpdateUserContactAtributeCommandHandle : IRequestHandler<UpdateUserContactAtributeCommand, UserContactModel>
    {
        private readonly MongoBD _mongoBD;
        public UpdateUserContactAtributeCommandHandle(MongoBD mongoBD)
        {
            _mongoBD = mongoBD;
        }
        public async Task<UserContactModel> Handle(UpdateUserContactAtributeCommand request, CancellationToken cancellationToken)
        {
           var updateContactUser = await _mongoBD.getContactById(request.id);
            if(updateContactUser == null)
            {
                return null;
            }
  
            if (request.UserName != null)
            {
                updateContactUser.Name = request.UserName;
            }
            if (request.Address != null)
            {
                updateContactUser.Address = request.Address;
            }
            if (request.UserEmail != null)
            {
                updateContactUser.Email = request.UserEmail;
            }
            if (request.BirthDate != null)
            {
                updateContactUser.BirthDate = request.BirthDate;
            }
            if (request.UserPhone != null)
            {
                updateContactUser.Phone = request.UserPhone;
            }

            await _mongoBD.updateAtributeContact(request.id, updateContactUser);
            return updateContactUser;
        }
    }
}
