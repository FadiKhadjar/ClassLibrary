namespace Shared.Interfaces;

public interface IContactService
{
    bool AddContactToList(IContact contact);

    IEnumerable<IContact> GetContactFromList();

    IContact GetContactFromList(string email);
}
