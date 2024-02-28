using Phonebook.Crud.Services;

namespace Phonebook.Crud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBookService phoneBookService = new PhoneBookService();
            phoneBookService.StartPhoneBookApp();
        }
    }
}

