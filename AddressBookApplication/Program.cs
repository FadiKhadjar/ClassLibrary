using AddressBookApplication.Services;
using System;

Console.Clear();
MenuService.ShowMenu();
Console.ReadKey();

MenuService.AddContactMenu();

Console.Clear();
MenuService.ShowAllContactsMenu();
Console.ReadKey();  
