﻿namespace Shared.Interfaces;

public interface IContact
{
    Guid Id { get; set; }

    string FirstName { get; set; }

    string LastName { get; set; }

    string Email { get; set; }

    string PhoneNumber { get; set; }

    string StreetName { get; set; }

    string CityName { get; set; }

    string PostalCode { get; set; }

}
