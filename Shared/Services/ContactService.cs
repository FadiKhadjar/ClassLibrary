using Newtonsoft.Json;
using Shared.Interfaces;
using System.Diagnostics;

namespace Shared.Services;

public class ContactService : IContactService
{

    /// <summary>
    /// Add a contact to a contact list
    /// </summary>
    /// <param name="contact">a contact of type IContact</param>
    /// <returns>Retur true if successful, or false if it fails or contact already exist</returns>

    private readonly IFileService _fileService = new FileService();
    private List<IContact> _contacts = [];
    private readonly string _filePath = @"c:\csharp-project\contacts.json";
    public bool AddContactToList(IContact contact)
    {
        try
        {
            if(!_contacts.Any(x => x.Email == contact.Email)) 
            {
                _contacts.Add(contact);
                
                string json = JsonConvert.SerializeObject(_contacts, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All});


                var result = _fileService.SaveContactToFile(_filePath, json);
                    return result;
            }


        }
        catch (Exception ex) { Debug.WriteLine("ContactService - AddContactToList ::" + ex.Message); }
        return false!;
    }

    public IEnumerable<IContact> GetContactFromList()
    {
        try
        {
            var content = _fileService.GetContactFromFile(_filePath);
            if(!string.IsNullOrEmpty(content)) 
            {
                _contacts = JsonConvert.DeserializeObject<List<IContact>>(content, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All })!;
                return _contacts;
            
            }


        }
        catch (Exception ex) { Debug.WriteLine("FileService - GetContactsFromList ::" + ex.Message); }
        return null!;
    }

    public IContact GetContactFromList(string email)
    {
        try
        {
            GetContactFromList();

            var contact = _contacts.FirstOrDefault(x => x.Email == email);
            return contact ??= null!;


        }
        catch (Exception ex) { Debug.WriteLine("ContactService - GetContactsFromList ::" + ex.Message); }
        return null!;
    }
}
