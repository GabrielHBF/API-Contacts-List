using DesafioTEcnico.Domain;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
namespace DesafioTEcnico.Infrastructure
{
    public class Repository : InterfaceRepository
    {
        public IMongoDatabase Database { get; }
        private readonly IMongoCollection<UserContactModel> listUsers;

        public Repository(IConfiguration conf) {
              
            var connectionString = conf.GetConnectionString("StringConection");
            var dataBaseName = conf.GetValue<string>("nameBD");

            var userContact = new MongoClient(connectionString);
            Database = userContact.GetDatabase(dataBaseName);

             listUsers = Database.GetCollection<UserContactModel>("Users");
        }

        public async Task<List<UserContactModel>> getListContact()
        {
          
            return await listUsers.Find(_ => true).ToListAsync();
        }

        public async Task createContactUser(UserContactModel newUserContact)
        {
                await listUsers.InsertOneAsync(newUserContact);
        }

        public async Task<UserContactModel> getContactById(string id)
        {
            return await listUsers.Find((contact) => contact.Id == id).FirstOrDefaultAsync();
        }

        public async Task<UserContactModel> updateContactById(string id, UserContactModel userUpdate)
        {
            var updateContact = await listUsers.FindOneAndReplaceAsync(contact => contact.Id == id, userUpdate);
            return updateContact;

        }

        public async Task<UserContactModel> delContactById(string id)
        {
            var delContact = await listUsers.FindOneAndDeleteAsync(contact => contact.Id == id);
            return delContact;
        }

        public async Task<UserContactModel> updateAttributeContact(string id, UserContactModel userContact)
        {
            var updateContact = userContact;
            await listUsers.ReplaceOneAsync(usercontact => usercontact.Id == id, updateContact);
            return updateContact;  
           
        }
    }
}