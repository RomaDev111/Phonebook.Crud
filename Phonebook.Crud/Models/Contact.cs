using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Crud.Models
{
    public class Contact
    {
        public Contact(string Name, string PhoneNumber, string Address) 
        { 
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
