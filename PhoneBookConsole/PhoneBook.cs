namespace PhoneBookConsole;

public class PhoneBook
{
    private List<Contact> _contacts { get; set; }

    public void AddContact(Contact contact)
    {
        _contacts.Add(contact);
    }
}