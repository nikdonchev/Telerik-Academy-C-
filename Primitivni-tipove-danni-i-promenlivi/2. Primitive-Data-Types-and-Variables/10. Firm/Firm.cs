using System;

class Firm
{
    static void Main()
    {
        Console.Write("First Name of the employe: ");
        string firstName = Console.ReadLine();
        Console.Write("Family Name of the employe: ");
        string familyName = Console.ReadLine();
        Console.Write("Age of the employe: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Gender of the employe Male or Female: ");
        string gender = Console.ReadLine();
        Console.Write("Enter the ID number of the employe: ");
        uint id = uint.Parse(Console.ReadLine());
        Console.Write("Enter the unique number of the employe from 27560000 to 27569999: ");
        uint uniqueNumber = uint.Parse(Console.ReadLine());
        Console.WriteLine("Information about employe:\n first name: {0}\n family name: {1}\n age: {2}\n gender: {3}\n id: {4}\n unique number: {5}", firstName, familyName, age, gender, id, uniqueNumber);
    }
}

