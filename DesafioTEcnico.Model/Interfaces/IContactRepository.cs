using DesafioTEcnico.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTEcnico.Domain.Interfaces
{
     public interface IContactRepository
    {
        Task<List<ContactEntity>> GetListAsync();
        Task<ContactEntity> GetByIdAsync(string id); 
        Task <ContactEntity> CreateAsync(ContactEntity newContact);
        Task<ContactEntity> UpdateAsync(string id, ContactEntity contactUpdate);
        Task<ContactEntity> DeleteAsync(string id);

    } 
}
