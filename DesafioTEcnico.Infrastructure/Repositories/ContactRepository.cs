using DesafioTEcnico.Domain.Entities;
using DesafioTEcnico.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
namespace DesafioTEcnico.Infrastructure.Repositories
{
    public class ContactRepository : IContactRepository
    {
        public IMongoDatabase MongoDb { get; }
        private readonly IMongoCollection<ContactEntity> listUsers;

        public ContactRepository(IConfiguration conf) {
              
            var connectionString = conf.GetConnectionString("StringConection");
            var dataBaseName = conf.GetValue<string>("nameBD");

            var contact = new MongoClient(connectionString);
            MongoDb = contact.GetDatabase(dataBaseName);

             listUsers = MongoDb.GetCollection<ContactEntity>("Users");
        }

        public async Task<List<ContactEntity>> GetListAsync()
        {
          
            return await listUsers.Find(_ => true).ToListAsync();
        }

        public async Task<ContactEntity> CreateAsync(ContactEntity newContact)
        {
                await listUsers.InsertOneAsync(newContact);
                return newContact;
        }

        public async Task<ContactEntity> GetByIdAsync(string id)
        {
            return await listUsers.Find((contact) => contact.Id == id).FirstOrDefaultAsync();
        }

        public async Task<ContactEntity> UpdateAsync(string id, ContactEntity userUpdate)
        {
            var updateContact = await listUsers.FindOneAndReplaceAsync(contact => contact.Id == id, userUpdate);
            return updateContact;

        }

        public async Task<ContactEntity> DeleteAsync(string id)
        {
            var delContact = await listUsers.FindOneAndDeleteAsync(contact => contact.Id == id);
            return delContact;
        }

    }
}