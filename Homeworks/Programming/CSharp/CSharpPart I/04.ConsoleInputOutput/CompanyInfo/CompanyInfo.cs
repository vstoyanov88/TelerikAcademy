using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter company name:");
            string companyName = Console.ReadLine();
            Console.WriteLine("Enter company address:");
            string companyaddress = Console.ReadLine();
            Console.WriteLine("Enter company phone number:");
            string companyPhone =Console.ReadLine();
            Console.WriteLine("Enter company fax:");
            long companyFax = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter company web site:");
            string companySite = Console.ReadLine();
            Console.WriteLine("Enter company managaer first and last name:");
            string managerName = Console.ReadLine();
            Console.WriteLine("Enter company manager age:");
            byte managerAge = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter company manager phone number:");
            string managerPhone = Console.ReadLine();

            Console.WriteLine(" Company name: {0}\n Company address: {1}\n Company phone number: {2}\n Company fax number: {3}\n Company web site: {4}\n Company manager name: {5}\n Manager age: {6}\n Manager phone number: {7}\n",companyName,companyaddress,companyPhone,companyFax,companySite,managerName,managerAge,managerPhone);
        }

    }

