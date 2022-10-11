namespace AddressBookSystem
{
    public class Program
    {
        const string filepath = @"C:\Users\Suraj Sinha\OneDrive\Desktop\Bridgelabz\AddressBook\AddressBookSystem\Contact.txt";
        static void Main(string[] args)
        {
            bool flag = true;
            AddressBook address = new AddressBook();//create a object address
            List<Contact> contacts = new List<Contact>();
            while (flag)
            {
                Console.WriteLine("please Enter Your option :");//enter the option which perform
                Console.WriteLine("1.Add \n2.Edit \n3.Delete \n 4.IO File\n 5.Read write csv File");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Contact contact = new Contact();//create contact object
                        {
                            Console.WriteLine("Enter the First Name");
                            contact.FirstName = Console.ReadLine();
                            Console.WriteLine("Enter the Last Name");
                            contact.LastName = Console.ReadLine();
                            Console.WriteLine("Enter the Address");
                            contact.Address = Console.ReadLine();
                            Console.WriteLine("Enter the City");
                            contact.City = Console.ReadLine();
                            Console.WriteLine("Enter the State");
                            contact.State = Console.ReadLine();
                            Console.WriteLine("Enter the Zip");
                            contact.Code = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the Email");
                            contact.Email = Console.ReadLine();
                        }
                        address.Addcontact(contact);// show add contact by objectname and methodname
                        Console.ReadKey();
                        break;
                    case 2:
                        string firstName = Console.ReadLine();
                        address.EditContact(firstName,contacts);
                        address.Display(contacts);
                        break;
                    case 3:
                        string FirstName = Console.ReadLine();
                        address.DeleteContact(FirstName);
                        address.Display(contacts);
                        break;
                    case 4:
                        address.ReadFromStreamReader(filepath);
                        break;
                    case 5:
                        AddressBook.PersonCSVContact();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}

                