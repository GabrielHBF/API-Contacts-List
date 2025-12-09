using DesafioTEcnico.Domain;
using MediatR;

namespace DesafioTEcnico.Application.Commands
{
    public class UpdateUserContactCommandHandle : IRequestHandler<UpdateUserContactCommand, UserContactModel>
    {
        private readonly InterfaceRepository _interfaceRepository;
        public UpdateUserContactCommandHandle(InterfaceRepository interfaceRepository)
        {
            _interfaceRepository = interfaceRepository;
        }
        public async Task<UserContactModel> Handle(UpdateUserContactCommand request, CancellationToken cancellationToken)
        {
            var updateUserContact = new UserContactModel
            {
                Id = request.Id,
                Name = request.UserName,
                Email = request.UserEmail,
                Phone = request.UserPhone,
                Address = request.Address,
                BirthDate = request.BirthDate,
            };

            await _interfaceRepository.updateContactById(request.Id, updateUserContact);
            return updateUserContact;
        }
    }
}
