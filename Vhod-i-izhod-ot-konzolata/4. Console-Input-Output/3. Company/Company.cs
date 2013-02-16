using System;

    class Company
    {
        static void Main()
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Company phone: ");
            int companyPhone = int.Parse(Console.ReadLine());
            Console.Write("Company fax: ");
            int companyFax = int.Parse(Console.ReadLine());
            Console.Write("Company web site: ");
            string companyWeb = Console.ReadLine();
            Console.Write("Company Manager first name: ");
            string firstMame = Console.ReadLine();
            Console.Write("Company Manager last name: ");
            string lastName = Console.ReadLine();
            string fullName = firstMame + " " + lastName;
            Console.Write("Manager age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Manager phone: ");
            int managerPhone = int.Parse(Console.ReadLine());
            Console.WriteLine(@"
        | Company name is {0}            
        | Company address: {1}           
        | Company number is: {2}         
        | Company fax is: {3}            
        | Company web site is: {4}       
        | Company manager is: {5}        
        | Manager age is: {6}            
        | Manager phone is: {7}          
", companyName, companyAddress, companyPhone, companyFax, companyWeb, fullName, age, managerPhone);
        }
    }
