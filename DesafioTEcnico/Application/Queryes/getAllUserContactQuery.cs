using DesafioTEcnico.Data;
using DesafioTEcnico.Models;
using MediatR;

namespace DesafioTEcnico.Application.Queryes
{
    public class getAllUserContactQuery : IRequest<List<UserContactModel>>
    {
        public List<UserContactModel> usersContacts { get; }

    }

    public class getAllUserContactQueryHandle : IRequestHandler<getAllUserContactQuery, List<UserContactModel>>
    {
        private readonly MongoBD _mongoDB;

        public getAllUserContactQueryHandle(MongoBD mongoDB)
        {
           this._mongoDB = mongoDB;
        }

        public async Task<List<UserContactModel>> Handle(getAllUserContactQuery request, CancellationToken cancellationToken)
        {
            List<UserContactModel> users = await _mongoDB.getListContact();
            return users;
    }
    }

}
