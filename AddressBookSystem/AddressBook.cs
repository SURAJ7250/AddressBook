using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        List<Contact> contacts = new List<Contact>();//create a contacts of list
        Contact storeContact = new Contact();//create storecontact object for delete contact
        public void Addcontact(Contact contact)//open parameterised constructor with contact
        {
            contacts.Add(contact);
            Display();
        }
        public void Display()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.Email);
            }
        }
        public void EditContact(String name)
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
                            Console.WriteLine("Enter Zip to update");
                            contact.Zip = Convert.ToInt32(Console.ReadLine());
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
                Display();
            }
        }
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
    }
}
