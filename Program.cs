using System;

namespace Prototype1                            //Deep copying using ICloneable interface
{
    class Person : ICloneable
    {
        public Person() { }
        public Person(Person person)            //copy constructor
        {
            _firstname = person._firstname;
            _lastname = person._lastname;
            _address = (Address)person._address.Clone();
        }
        public Object Clone()
        {
            return new Person(this);
        }
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }
        private Address _address;
        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        private string _firstname;
        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        private string _lastname;
    }
        class Address : ICloneable
        {
            public Address() { }
            public Address(Address address)
            {
                _addressline1 = address._addressline1;
                _addressline2 = address._addressline2;
            }

        public object Clone()
        {
            return new Address(this);
        }
            public string AddressLine1
            {
                get { return _addressline1; }
                set { _addressline1 = value; }
            }
            private string _addressline1;
            public string AddressLine2
            {
                get { return _addressline2; }
                set { _addressline2 = value; }
            }
            private string _addressline2;
        }
    
    class Program
    {
        public static void Main(string[] args)
        {
            var person1 = new Person()
            {
                FirstName = "Ashish",
                LastName = "Singh",
                Address  = new Address()
                {
                    AddressLine1 = "London Street",
                    AddressLine2 = "North"
                }
                
            };
            var person2 = (Person)person1.Clone();        //or var person2 = new Person(person1);
            //Console.WriteLine(person1.FirstName);
            //Console.WriteLine(person2.FirstName);
            //Console.WriteLine("");

            //person2.FirstName = "Sachin";
            //Console.WriteLine(person2.FirstName);
            Console.WriteLine(person1.Address.AddressLine1);
            Console.WriteLine(person2.Address.AddressLine1);
            person2.Address.AddressLine1 = "Londonnnn";
            Console.WriteLine(person1.Address.AddressLine1);
            Console.WriteLine(person2.Address.AddressLine1);

        }
    }
}

