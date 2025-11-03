using DesafioTEcnico.Application.interfaces;
using DesafioTEcnico.Domain;
using MediatR;

namespace DesafioTEcnico.Application.Commands
{
    public class UpdateUserContactCommandHandle : IRequestHandler<UpdateUserContactCommand, UserContactModel>
    {
        private readonly InterfaceUserContatctBD _interfaceRepository;
        public UpdateUserContactCommandHandle(InterfaceUserContatctBD interfaceRepository)
        {
            _interfaceRepository = interfaceRepository;
        }
        public async Task<UserContactModel> Handle(UpdateUserContactCommand request, CancellationToken cancellationToken)
        {
            var updateUserContact = new UserContactModel
            {
                Id = request.id,
                Email = request.UserEmail,
                Phone = request.UserPhone,
                Address = request.Address,
                BirthDate = request.BirthDate,
            };

            await _interfaceRepository.updateContactById(request.id, updateUserContact);
            return updateUserContact;
        }
    }
}
