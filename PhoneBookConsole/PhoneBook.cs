namespace PhoneBookConsole;

public class PhoneBook
{
    private List<Contact> _contacts { get; set; }

    private void DisplayContactDetail(Contact contact)
    {
        Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");  
    }

    public void AddContact(Contact contact)
    {
        _contacts.Add(contact);
    }

    public void DisplayContact(string number)
    {
        var contact = _contacts.FirstOrDefault(c => c.Number == number);
        if (contact == null)
        {
            Console.WriteLine("Contact not found");
        }
        else
        {
            DisplayContactDetail(contact);
        }
        {
            
        }
    }

    public void DisplayAllContacts()
    {
        foreach (var contact in _contacts)
        {
            DisplayContactDetail(contact);
        }
    }
}