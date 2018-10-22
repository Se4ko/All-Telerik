using System;
/*
2. Print Company Information

A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
*/
class PrintCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Please input the needed information.");
        Console.Write("Company name: ");
        string cName = Console.ReadLine();
        Console.Write("Adress: ");
        string adress = Console.ReadLine();
        Console.Write("Phone number: ");
        string phone = Console.ReadLine();
        Console.Write("Fax number: ");
        string fax = Console.ReadLine();
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager's first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Manager's last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Manager's age: ");
        string age = Console.ReadLine();
        Console.Write("Manager's phone number: ");
        string manPhone = Console.ReadLine();

        Console.WriteLine(cName + "\nAdress: " + adress + "\nPhone: " + phone + "\nFax: " + fax + "\nWeb site: " + webSite + "\nManager: " + firstName + " " + lastName + " ( age: {0}, tel: {1} )",age,manPhone);
    }
}
