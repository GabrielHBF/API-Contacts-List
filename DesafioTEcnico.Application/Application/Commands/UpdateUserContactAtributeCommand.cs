using DesafioTEcnico.Domain;
using MediatR;

namespace DesafioTEcnico.Application.Commands
{
    public class UpdateUserContactAtributeCommand : IRequest<UserContactModel>
    {
        public string? Id {  get; set; }
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }
        public string? UserPhone { get; set; }
        public DateTime BirthDate { get; set; }
        public List<string>? Address { get; set; }

    }
}
