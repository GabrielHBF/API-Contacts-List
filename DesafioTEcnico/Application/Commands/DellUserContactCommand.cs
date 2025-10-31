using DesafioTEcnico.Models;
using MediatR;

namespace DesafioTEcnico.Application.Commands
{
    public class DellUserContactCommand : IRequest<UserContactModel>
    {
        public string id { get; set; }
    }
}
