using Contact.Models;

namespace Contact.Infrastructure
{
    public interface IContactService
    {
        public Task<ContactDto> GetById(int id);
        public Task<List<ContactDto>> GetAll(int id);
        public Task<bool> Create(ContactDto contact);
        public Task<bool> Update(ContactDto contact);

    }
}
