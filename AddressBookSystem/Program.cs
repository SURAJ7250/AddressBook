namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact()
            {
                FirstName = "suraj",
                LastName = "sinha",
                Address = "Hadapsar",
                City = "Pune",
                State = "Maharashtra",
                Zip = 411042,
                Email = "xyz@gmail.com",
            };
            Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.Email);
        }
    }
    }
}