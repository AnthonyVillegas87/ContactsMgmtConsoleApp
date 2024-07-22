// See https://aka.ms/new-console-template for more information


namespace PhoneBookConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your PhoneBook!");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Select an Operation");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Display contact by number");
            Console.WriteLine("3. View all Contacts");
            Console.WriteLine("4. Search for contacts by name");
            Console.WriteLine("Press x to Exit.");

            var userInput = Console.ReadLine();
            var phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1" :
                        Console.WriteLine("Contact name: ");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact number: ");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        
                        break;
                    case "2" :
                        Console.WriteLine("Contact number to search: ");
                        var searchNumber = Console.ReadLine();
                        phoneBook.DisplayContact(searchNumber);
                        
                        break;
                    case "3" :
                        
                        phoneBook.DisplayAllContacts();
                        break;
                    case "4" :
                        Console.WriteLine("Search contact by name: ");
                        var searchName = Console.ReadLine();
                        
                        phoneBook.DisplayMatchingContacts(searchName);
                        break;
                    case "x" :
                        return;
                    default:
                        Console.WriteLine("Select a valid operation.");
                        break;
                }

                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();

            }
           
        }
    }
}

