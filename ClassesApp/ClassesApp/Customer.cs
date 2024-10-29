using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Customer

       
    {
        // static field to hold the next ID available
        private static int nextId = 0;

        // Read-only instance field initialized from the constructor
        private readonly int _id;

        // Backing field for write-only property
        private string _password;

        // Write-Only property
        public string Password
        {
            set { _password = value; } }

        // Read Only Property
        public int Id { get { return _id; } }

        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber {  get; set; }

        // Custom Constructor

        public Customer(string name, string address, string contactNumber) 
        {
            _id = nextId++;
            Name = name;
            Address = address;  
            ContactNumber = contactNumber;

        }

        public Customer(string name)
        {
            _id = nextId++;
            Name = name;
        }

        public Customer()
        {
            _id = nextId++;
            Name = "DefaultName";
            Address = "No Address";
            ContactNumber = "No ContactNumber";
        }

        public void SetDetails(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Details about the customer: Name is {Name} and Id is {_id}");
        }
    }
}
