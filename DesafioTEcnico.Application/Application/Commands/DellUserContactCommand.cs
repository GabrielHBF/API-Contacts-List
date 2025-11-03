using DesafioTEcnico.Domain;
using MediatR;

namespace DesafioTEcnico.Application.Commands
{
    public class DellUserContactCommand : IRequest<UserContactModel>
    {
        public string id { get; set; }
    }
}
