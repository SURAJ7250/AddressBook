using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        List<Contact> contacts = new List<Contact>();//create a contacts of list
        Contact contact = new Contact();//create a conatct object
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
    }
}
