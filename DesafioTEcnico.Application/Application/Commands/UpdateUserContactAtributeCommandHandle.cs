using DesafioTEcnico.Domain;
using MediatR;

namespace DesafioTEcnico.Application.Commands
{
    public class UpdateUserContactAtributeCommandHandle : IRequestHandler<UpdateUserContactAtributeCommand, UserContactModel>
    {
        private readonly InterfaceRepository _interfaceRepository;
        public UpdateUserContactAtributeCommandHandle(InterfaceRepository interfaceRepository)
        {
            _interfaceRepository = interfaceRepository;
        }
        public async Task<UserContactModel> Handle(UpdateUserContactAtributeCommand request, CancellationToken cancellationToken)
        {
           var updateContactUser = await _interfaceRepository.getContactById(request.Id);
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

            await _interfaceRepository.updateAttributeContact(request.Id, updateContactUser);
            return updateContactUser;
        }
    }
}
