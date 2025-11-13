using DesafioTEcnico.Application.Commands;
using DesafioTEcnico.Application.Queryes;
using DesafioTEcnico.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTEcnico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserContactController : ControllerBase
    {
        private readonly IMediator _mediatR;
     
        public UserContactController(IMediator mediatR)
        {
            this._mediatR = mediatR;
        }

        [HttpGet]
        public async Task<IActionResult> getUsers()
        {
            var query = new GetAllUserContactQuery();

            List<UserContactModel> usersList =  await _mediatR.Send(query);
            return Ok(usersList);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getUserByID(string id)
        {
            var query = new GetUserContactByIdQuery();

            query.UserId = id;

            var user = await _mediatR.Send(query);
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> createNewUser([FromBody] CreateUserContactCommand command)
        {
            var createContact = await _mediatR.Send(command);
            return Ok(createContact);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> updateUserContact(string id, [FromBody] UpdateUserContactCommand command)
        {
            command.Id = id;
            var updateContact = await _mediatR.Send(command);
            return Ok(updateContact);
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> updateAtributeContact(string id, [FromBody] UpdateUserContactAtributeCommand command)
        {
           command.Id = id;
           var updateAtributeContact = await _mediatR.Send(command);
           return Ok(updateAtributeContact);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> deleteUserContact(string id,DellUserContactCommand command)
        {
            command.id = id;
            var deleteUserContact = await _mediatR.Send(command);
            return Ok(deleteUserContact);
        }



    }
}
