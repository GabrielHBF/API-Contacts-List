using DesafioTEcnico.Application.Application.Commands.Contact;
using DesafioTEcnico.Application.Application.Queryes.Contact;
using DesafioTEcnico.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTEcnico.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactController(IMediator mediatR) : ControllerBase
{
    private readonly IMediator _mediatR = mediatR;

    [HttpGet]
    public async Task<IActionResult> GetContacts()
    {
        List<ContactEntity> resultList =  await _mediatR.Send(new GetAllContactQuery());
        return Ok(resultList);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserByID(string id)
    {
        var result = await _mediatR.Send(
        new GetContactByIdQuery()
        {
            ContactId = id
        });
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateNewUser([FromBody] AddContactCommand addContactCommand)
    {
        var result = await _mediatR.Send(addContactCommand);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUserContact(string id, [FromBody] UpdateContactCommand updateContactCommand)
    {
        updateContactCommand.Id = id;
        var result = await _mediatR.Send(updateContactCommand);
        return Ok(result);
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> UpdateAtributeContact(string id, [FromBody] UpdateContactAtributeCommand updateContactAtributeCommand)
    {
        updateContactAtributeCommand.Id = id;
       var result = await _mediatR.Send(updateContactAtributeCommand);
       return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUserContact(string id,DeleteContactCommand deleteContactCommand)
    {
        deleteContactCommand.Id = id;
        var result = await _mediatR.Send(deleteContactCommand);
        return Ok(result);
    }



}
