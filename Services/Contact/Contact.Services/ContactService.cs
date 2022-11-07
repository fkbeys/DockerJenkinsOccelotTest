using Contact.Infrastructure;
using Contact.Models;

namespace Contact.Services
{
    public class ContactService : IContactService
    {
        public Task<bool> Create(ContactDto contact)
        {
            return Task.FromResult(true);
        }

        public Task<List<ContactDto>> GetAll(int id)
        {
            var contacts = new List<ContactDto>();
            contacts.Add(new ContactDto { });

            return Task.FromResult(contacts);

        }

        public Task<ContactDto> GetById(int id)
        {

            var contact = new ContactDto
            {
                contactId = 1,
                contactLat = 10,
                contactLong = 20,
                contactName = "Kaya",
                contactSurname = "F",
            };

            return Task.FromResult(contact);
        }

        public Task<bool> Update(ContactDto contact)
        {
            return Task.FromResult(true);
        }
    }
}
