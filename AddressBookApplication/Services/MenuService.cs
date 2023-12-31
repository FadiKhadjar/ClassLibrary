using Shared.Interfaces;
using Shared.Models;
using Shared.Services;

namespace AddressBookApplication.Services;

internal class MenuService
{

    private static readonly IContactService _contactService = new ContactService();


    public static void AddContactMenu() 
    {
        IContact contact = new Contact();

        Console.Write("Enter your first name: ");
        contact.FirstName = Console.ReadLine()!;


        Console.Write("Enter your last name: ");
        contact.LastName = Console.ReadLine()!;

        Console.Write("Enter your email: ");
        contact.Email = Console.ReadLine()!;

        Console.Write("Enter your phonenumber: ");
        contact.PhoneNumber = Console.ReadLine()!;

        Console.Write("Enter your street name: ");
        contact.StreetName = Console.ReadLine()!;

        Console.Write("Enter your city name: ");
        contact.CityName = Console.ReadLine()!;

        Console.Write("Enter your postal code: ");
        contact.PostalCode = Console.ReadLine()!;

        _contactService.AddContactToList(contact);

    }

    public static void ShowAllContactsMenu() 
    {
        var contacts = _contactService.GetContactFromList();
        foreach(var contact in contacts) 
        {
            if (contact is IContact Contact)
                Console.WriteLine($"{contact.FirstName} {contact.LastName} \n{contact.Email} \n{contact.PhoneNumber} \n{contact.StreetName} \n{contact.CityName} {contact.PostalCode}");
        
        }

        Console.WriteLine();
    
    
    }


}
