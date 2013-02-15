using System;

class Program
{
    static void Main()
    {
        string firstName = "Ivan";
        string secondName = "Ivanov";
        string thirdName = "Ivanov";
        string bankName = "X";
        double balance = 222.22;
        string iban = "BG12BGBG12121212";
        string bicCode = "BGBG12";
        string card1 = "1111-1111-1111-1111";
        string card2 = "2222-2222-2222-2222";
        string card3 = "3333-3333-3333-3333";
        Console.WriteLine(" Client name: {0} {1} {2}\n Bank name: {3}\n Client balance: {4}\n Client IBAN: {5}\n Client Bic: {6}\n Client credit card number:\n Card one: {7}\n Card two: {8}\n Card three: {9}",firstName,secondName,thirdName,bankName,balance,iban,bicCode,card1,card2,card3);

    }
}

