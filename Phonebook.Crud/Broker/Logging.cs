using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phonebook.Crud.Models;

namespace Phonebook.Crud.Broker
{
    internal class Logging
    {
        public void ShowContacts(List<Contact> contacts) 
        {
            for (int i = 0; i < contacts.Count; i++) 
            {
                var contact = contacts[i];
                Console.WriteLine(contact.Id + contact.Name + contact.PhoneNumber + contact.Address);
            }
        }
    }
}
