using System;

class Bank
{
    static void Main()
    {
        string firstName = "Nikolay";
        string middleName = "Vanev";
        string lastName = "Donchev";
        decimal moneyBalance = 12300000.45m;
        string bankName = "RBB";
        ushort iban = 65148;
        string bicCode = "AREV45";
        long creditCardNumberOne = 1574548546755574L;
        long creditCardNumberTwo = 1567597857856225L;
        long creditCardNumberThree = 5985698798756897L;
        Console.WriteLine(@"Information about bank account:
first name: {0}
middle name: {1}
last name: {2}
money balance: {3}
bank name: {4}
IBAN: {5}
BIC Code: {6}
First Credit Card Number: {7} 
Second Credit Card Number: {8}
Third Credit Card Number: {9}", firstName, middleName, lastName, moneyBalance, bankName, iban, bicCode, creditCardNumberOne, creditCardNumberTwo, creditCardNumberThree );
    }
}

