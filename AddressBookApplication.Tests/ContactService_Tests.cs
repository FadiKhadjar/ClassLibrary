using Shared.Interfaces;
using Shared.Models;
using Shared.Services;

namespace AddressBookApplication.Tests;

public class ContactService_Tests
{

    [Fact]
    public void AddToListShould_AddOneContactToContactList_ThenReturnTrue() 
    {

        //Arrange
        IContact contact = new Contact { FirstName = "", LastName = "", Email = "", PhoneNumber = "", StreetName = "", CityName = "", PostalCode = ""  };
        IContactService contactService = new ContactService();
        
        //Act 
        bool result = contactService.AddContactToList(contact);


        //Assert
        Assert.True(result );
   
    
    }
}
