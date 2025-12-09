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
  
            if (!string.IsNullOrEmpty(request.UserName) && request.UserName != "string")
            {
                updateContactUser.Name = request.UserName;
            }
            if (request.Address != null && request.Address.Count > 0 && request.Address[0] != "string")
            {
                updateContactUser.Address = request.Address;
            }
            if (!string.IsNullOrEmpty(request.UserEmail) && request.UserEmail != "string")
            {
                updateContactUser.Email = request.UserEmail;
            }
            if (request.BirthDate != null)
            {
                updateContactUser.BirthDate = request.BirthDate;
            }
            if (!string.IsNullOrEmpty(request.UserPhone) && request.UserPhone != "string")
            {
                updateContactUser.Phone = request.UserPhone;
            }

            await _interfaceRepository.updateAttributeContact(request.Id, updateContactUser);
            return updateContactUser;
        }
    }
}
