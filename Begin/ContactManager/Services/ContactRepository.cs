using ContactManager.Models;

namespace ContactManager.Services
{
    public class ContactRepository
    {
        // HttpContext does not have Cache in this version. This is a quick replacement
        private Contact[] contacts;

        public ContactRepository()
        {
            contacts = new Contact[]
            {
                new Contact
                {
                    Id = 1, Name = "Glenn Block"
                },
                new Contact
                {
                    Id = 2, Name = "Dan Roth"
                }
            };
        }

        public Contact[] GetAllContacts()
        {
            return contacts;
        }

        public bool SaveContact(Contact contact)
        {
            try
            {
                contacts.Append(contact);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
