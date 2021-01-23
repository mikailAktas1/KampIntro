using System;

namespace RefrenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;

            Console.WriteLine("sayi1:" + sayi1);
            //arrays. class,interface,refrencetypes
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int []sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;

            Console.WriteLine("Sayılar1[0]="  + sayilar1[0]);

            Person person = new Person();
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1;
            person1.FirstName = "derin";

            Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            Employee employee = new Employee();


        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
}
