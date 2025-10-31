using DesafioTEcnico.Data;
using DesafioTEcnico.Models;
using MediatR;

namespace DesafioTEcnico.Application.Queryes
{
    public class getUserContactByIdQuery : IRequest <UserContactModel>
    {
            public string UserId { get; set; }

    }

        public class getUserContactByIdQueryHandler : IRequestHandler<getUserContactByIdQuery, UserContactModel>
        {
            private readonly MongoBD _mongoDB;

            public getUserContactByIdQueryHandler(MongoBD mongoDB)
            {
                this._mongoDB = mongoDB;
            }

            public async Task<UserContactModel> Handle(getUserContactByIdQuery request, CancellationToken cancellationToken)
            {
                var user = await _mongoDB.getContactById(request.UserId);
                return user;
            }

    }

    }

