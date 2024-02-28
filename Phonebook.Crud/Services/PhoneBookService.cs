using Phonebook.Crud.Models;
using System;

namespace Phonebook.Crud.Services
{
    internal class PhoneBookService
    {
        public void StartPhoneBookApp()
        {
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
                        AddPhoneBook();
                        break;
                    case 2:
                        DisplayAllPhoneBooks();
                        break;
                    case 3:
                        DeletePhoneBookByID();
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
        private PhoneBook[] PhoneBooks { get; set; } = new PhoneBook[10];
        private int nextId = 1;

        public void AddPhoneBook()
        {
            if (nextId <= PhoneBooks.Length)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter phone number: ");
                string phone = Console.ReadLine();

                PhoneBooks[nextId - 1] = new PhoneBook
                {
                    Id = nextId,
                    Name = name,
                    Phone = phone
                };
                nextId++;
            }
            else
            {
                Console.WriteLine("Phone book is full. Cannot add more entries.");
            }
        }

        public void DeletePhoneBookByID()
        {
            Console.Write("Enter the ID of the phone book to delete: ");
            int idToDelete = int.Parse(Console.ReadLine());

            if (idToDelete >= 1 && idToDelete <= PhoneBooks.Length)
            {
                PhoneBooks[idToDelete - 1] = null;
            }
            else
            {
                Console.WriteLine("Invalid ID.");
            }
        }

        public void DisplayAllPhoneBooks()
        {
            foreach (var phoneBook in PhoneBooks)
            {
                if (phoneBook != null)
                {
                    Console.WriteLine($"{phoneBook.Id} - {phoneBook.Name} - {phoneBook.Phone}");
                }
            }
        }

       
    }
}
