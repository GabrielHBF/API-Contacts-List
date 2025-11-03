using DesafioTEcnico.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTEcnico.Application.interfaces
{
     public interface InterfaceUserContatctBD
    {
         Task<List<UserContactModel>> getListContact();
         Task createContactUser(UserContactModel newUserContact);

         Task<UserContactModel> getContactById(string id);

         Task<UserContactModel> updateContactById(string id, UserContactModel userUpdate);

         Task<UserContactModel> delContactById(string id);

         Task<UserContactModel> updateAttributeContact(string id, UserContactModel userContact);
     } 
}
