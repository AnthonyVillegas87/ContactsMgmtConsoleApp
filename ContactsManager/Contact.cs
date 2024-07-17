namespace ContactsManager;

public class Contact
{
    private string Name { get; set; }
    private string PhoneNumber { get; set; }
    private string Email { get; set; }

    public void MainPrompt()
    {
        Console.WriteLine("Contacts Manager");
        Console.WriteLine("----------------");
        Console.WriteLine("1. View Contacts");
        Console.WriteLine("2. Add Contact");
        Console.WriteLine("3. Search by Contact Name");
        Console.WriteLine("4. Delete Contact");
        Console.WriteLine("5. Update Contact");
        Console.WriteLine("6. Exit");
        Console.Write("Choose an option: ");
    }
}