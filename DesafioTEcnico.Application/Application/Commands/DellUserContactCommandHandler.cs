using DesafioTEcnico.Application.interfaces;
using DesafioTEcnico.Domain;
using MediatR;

namespace DesafioTEcnico.Application.Commands
{
    public class DellUserContactCommandHandler : IRequestHandler<DellUserContactCommand, UserContactModel>
    {
        private readonly InterfaceUserContatctBD _interfaceRepository;
        public DellUserContactCommandHandler(InterfaceUserContatctBD interfaceRepository)
        {
            _interfaceRepository = interfaceRepository;
        }
        async Task<UserContactModel> IRequestHandler<DellUserContactCommand, UserContactModel>.Handle(DellUserContactCommand request, CancellationToken cancellationToken)
        {
            var userDelet = await _interfaceRepository.delContactById(request.id);
            return userDelet;

        }        
       
    }
}
