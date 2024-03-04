using Phonebook.Crud.Broker;
using Phonebook.Crud.Models;
using PhoneBook.Crud.PhoneBookService;
namespace Phonebook.Crud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBookService bookService = new BookService();
            Logging logging = new Logging();
           bool running = true;
            while (running)
            {
                Console.WriteLine("1. Add a new phone book entry");
                Console.WriteLine("2. Display all phone books");
                Console.WriteLine("3. Delete a phone book by ID");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        var contact = new Contact( Name: "John", PhoneNumber: "123456789", Address: "Tashkent, Uzbekistan"); 
                        bookService.AddContact(contact);

                        break;
                    case 2:
                        var contacts = bookService.GetContacts();
                        logging.ShowContacts(contacts);
                        break;
                    case 3:
                      //  bookService.UpdateContact();
                        break;
                    case 4:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            
                        
        }
    }
}

