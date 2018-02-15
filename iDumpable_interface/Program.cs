/*
 * C# Program to Demonstrate IDumpable Interface
 */

using System;

namespace iDumpable_interface
{
    interface IDumpable
    {
        string Name { get; set; }
        void Dump();
    }

    class Fraction : IDumpable
    {
        int z, n;
        string name;

        public Fraction(int z, int n)
        {
            this.z = z; this.n = n;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public void Dump()
        {
            Console.WriteLine("Fraction : " + z + "/" + n);
        }
    }

    class Person : IDumpable
    {
        string name;
        public string address;
        public int phone;

        public Person(string name, string address, int phone)
        {
            this.name = name; this.address = address; this.phone = phone;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Dump()
        {
            Console.WriteLine("Person Details : {0}, {1}, {2}", name, address, phone);
        }
    }
}
