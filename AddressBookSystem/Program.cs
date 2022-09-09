namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            AddressBook address = new AddressBook();//create a object address
            while (flag)
            {
                Console.WriteLine("please Enter Your option :");//enter the option which perform
                Console.WriteLine("1.Add \n2.Edit");
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
                            contact.Zip = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the Email");
                            contact.Email = Console.ReadLine();
                        }
                        address.Addcontact(contact);// show add contact by objectname and methodname
                        Console.ReadKey();
                        break;
                    case 2:
                        string firstName = Console.ReadLine();
                        address.EditContact(firstName);
                        address.Display();
                        break;
                    default:
                        Console.WriteLine("Please enter valid option");
                        break;
                }
            }
        }
    }
    
}