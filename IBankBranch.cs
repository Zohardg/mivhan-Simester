using System;

namespace AccountManagement
{
    public class Customer
    {
        private int id;
        private string name;
        private string phoneNumber;

        public Customer(int id, string name, string phoneNumber)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
        }

        public int GetId()
        {
            return this.id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetPhoneNumber()
        {
            return this.phoneNumber;
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public void PrintDetails()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Phone Number: " + this.phoneNumber);
        }
    }
}
