using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace בוחן_אמצע_סימסטר
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

        public void PrintDetails()
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Phone Number: {phoneNumber}");
        }
    }
}
