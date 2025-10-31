using DesafioTEcnico.Data;
using DesafioTEcnico.Models;
using MediatR;

namespace DesafioTEcnico.Application.Commands
{
    public class DellUserContactCommandHandler : IRequestHandler<DellUserContactCommand, UserContactModel>
    {
        private readonly MongoBD _mongoBD;
        public DellUserContactCommandHandler(MongoBD mongoBD)
        {
            _mongoBD = mongoBD;
        }
        async Task<UserContactModel> IRequestHandler<DellUserContactCommand, UserContactModel>.Handle(DellUserContactCommand request, CancellationToken cancellationToken)
        {
            var userDelet = await _mongoBD.delContactById(request.id);
            return userDelet;

        }        
       
    }
}
