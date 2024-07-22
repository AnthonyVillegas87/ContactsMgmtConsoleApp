using System.Reflection;

namespace ContactsManager;

public class Contact
{
    private string Name { get; set; }
    private string PhoneNumber { get; set; }
    
    private string Email { get; set; }
    private string CONTACTS_FILE;
    public void MainPrompt()
    {
        GetContactsFilePath();
        List<Contact> contacts = LoadContacts();
        Console.WriteLine("Contacts Manager");
        Console.WriteLine("----------------");
        Console.WriteLine("1. View Contacts");
        Console.WriteLine("2. Add Contact");
        Console.WriteLine("3. Search by Contact Name");
        Console.WriteLine("4. Delete Contact");
        Console.WriteLine("5. Update Contact");
        Console.WriteLine("6. Exit");
        Console.Write("Choose an option: ");
        
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                ViewContacts(contacts);
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    }

    public string GetContactsFilePath()
    {
        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"./contacts.txt");
        //string[] files = File.ReadAllLines(path);
        return path;
    }

    public List<Contact> LoadContacts()
    {
        List<Contact> contacts = new List<Contact>();

        if (File.Exists(CONTACTS_FILE))
        {
            string[] lines = File.ReadAllLines(CONTACTS_FILE);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                Contact contact = new Contact
                {
                    Name = parts[0],
                    Email = parts[1],
                    PhoneNumber = parts[2]
                };
                contacts.Add(contact);
            }
        }

        return contacts;
    } 
    
    public void ViewContacts(List<Contact> contacts)
    {
        Console.WriteLine("Contacts:");
        Console.WriteLine("--------");

        foreach (Contact contact in contacts)
        {
            Console.WriteLine($"Name: {contact.Name}, Email: {contact.Email}, Phone: {contact.PhoneNumber}");
        }
    }
    
    
    
    
}