using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Firstname = "Ali";
            customer1.Lastname = "Yıldırım";
            customer1.City = "İstanbul";

            Customer customer2 = new Customer();
            customer2.Firstname = "Mislina";
            customer2.Lastname = "Karadeniz";
            customer2.City = "Ankara";

            CustomerManager customerManager = new CustomerManager();

            Customer[] customers = new Customer[] { customer1, customer2 };
            foreach (Customer customer in customers)
            {
                customerManager.Add();
                customerManager.List();
                Console.WriteLine("\nMüşteri Adı: " + customer.Firstname + "\nMüşteri Soyadı: " + customer.Lastname + "\nŞehir: " + customer.City + "\n--------------------------------");
                customerManager.Update();
            }
            customerManager.Delete();
        }
    }
}
