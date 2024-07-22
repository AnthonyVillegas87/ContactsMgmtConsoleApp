namespace PhoneBookConsole;

public class PhoneBook
{
    private List<Contact> _contacts { get; set; } = new List<Contact>();

    private void DisplayContactDetail(Contact contact)
    {
        Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");  
    }

    private void DisplayContactsDetails(List<Contact> contacts)
    {
        foreach (var contact in _contacts)
        {
            DisplayContactDetail(contact);
        }
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
       DisplayContactsDetails(_contacts);
    }

    public void DisplayMatchingContacts(string searchName)
    {
        var matchingContact = _contacts.Where(c => c.Name.Contains(searchName)).ToList();

       DisplayContactsDetails(matchingContact);
    }
}