using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Pipelines;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        public Dictionary<string, List<Contact>> AddressBookSystem = new Dictionary<string, List<Contact>>();
        List<Contact> contacts = new List<Contact>();//create a contacts of list
        Contact storeContact = new Contact();//create storecontact object for delete contact
        public static Dictionary<string, List<Contact>> addressBookSystem = new Dictionary<string, List<Contact>>();
        //private static readonly object addressBookSystem;
        //UC2
        public void Addcontact(Contact contact)//open parameterised constructor with contact
        {
            contacts.Add(contact);
            Display(contacts);
        }
        public void Display(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Code + "\n" + contact.Email);
            }
        }
        //UC3
        public void EditContact(String name, List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {

                if (contact.FirstName == (name))
                {
                    Console.WriteLine("Enter the option to update\n 1. last Name \n 2.Address \n 3. City \n 4. State \n 5. Zip \n \n 6.Email");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter lastname to update");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter Adderss to update");
                            contact.Address = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter City to update");
                            contact.City = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter State to update");
                            contact.State = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter Code to update");
                            contact.Code = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 6:
                            Console.WriteLine("Enter Email to update");
                            contact.Email = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Enter the valid option");
                            break;
                    }
                }
                Display(contacts);
            }
        }
        //UC4
        public void DeleteContact(string name) // delete contact
        {
            foreach (var contact in contacts)
            {
                if (contact.FirstName == name)
                {
                    this.storeContact = contact;
                }
            }
            contacts.Remove(this.storeContact);
        }
        //UC13
        public void ReadFromStreamReader(string filepath)
        {
            using (StreamReader sr = File.OpenText(filepath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
        //UC14
        public static void PersonCSVContact()
        {
            string importFilepath = @"C:\Users\Suraj Sinha\OneDrive\Desktop\Bridgelabz\AddressBook\AddressBookSystem\contact.csv";
            string exportfilepath = @"C:\Users\Suraj Sinha\OneDrive\Desktop\Bridgelabz\AddressBook\AddressBookSystem\address.csv";
            //reading csv fie
            using (var reader = new StreamReader(importFilepath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Contact>().ToList();
                Console.WriteLine("Read data successfully from addresses csv");
                foreach (Contact contact in records)
                {
                    Console.WriteLine("\t" + contact.FirstName);
                    Console.WriteLine("\t" + contact.LastName);
                    Console.WriteLine("\t" + contact.Address);
                    Console.WriteLine("\t" + contact.City);
                    Console.WriteLine("\t" + contact.State);
                    Console.WriteLine("\t" + contact.Code);
                    Console.WriteLine("\t" + contact.Email);
                }
                Console.WriteLine("\n******************Now reading from csv file and write to csv file********");
                //writing csv files
                using (var writer = new StreamWriter(exportfilepath))
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
            }
        }
    }
}

