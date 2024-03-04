using System;
using System.Collections.Generic;
using System.Linq;
using Phonebook.Crud.Models;

namespace PhoneBook.Crud.PhoneBookService
{
      public interface IBookService
    {
        Contact AddContact(Contact contact);
        Contact GetContact(Guid id);
        Contact UpdateContact(Contact contact);
        bool DeleteContact(Guid id);
        List<Contact> GetContacts();

    }

    public class BookService : IBookService
    {
        private readonly List<Contact> _contacts;

        public BookService()
        {
            _contacts = new List<Contact>();
        }

        public Contact AddContact(Contact contact)
        {
            contact.Id = Guid.NewGuid();
            _contacts.Add(contact);
            return contact;
        }

        public Contact GetContact(Guid id)
        {
            return _contacts.FirstOrDefault(c => c.Id == id);
        }

        public Contact UpdateContact(Contact contact)
        {
            var contactToUpdate = _contacts.FirstOrDefault(c => c.Id == contact.Id);
            if (contactToUpdate != null)
            {
                contactToUpdate.Name = contact.Name;
                contactToUpdate.PhoneNumber = contact.PhoneNumber;
                contactToUpdate.Address = contact.Address;
                return contactToUpdate;
            }
            throw new Exception("Contact not found");
        }

        public bool DeleteContact(Guid id)
        {
            var contactToDelete = _contacts.FirstOrDefault(c => c.Id == id);
            if (contactToDelete != null)
            {
                _contacts.Remove(contactToDelete);
                return true;
            }
            return false;
        }

        public List<Contact> GetContacts() 
        {
            return _contacts;
        }
    }
}
