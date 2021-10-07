using System;

namespace Part30Interfaces
{


    interface IPrint
    {
        void print();
        void get();
    }
    interface ICricket
    {
        void wicket();
        void runs();
    }
        class Customer : IPrint,ICricket
        {
            public void print1()
            {
                Console.WriteLine("Interface Implimentation"); ;
            }
            public void print()
            {
                Console.WriteLine("Print Method From Interface"); 
            }
            public void get()
            {

            }

        public void wicket()
        {
            Console.WriteLine("5 wickets down");

        }

        public void runs()
        {
            Console.WriteLine("201 runs target");
        }
    }
        class Student:IPrint
        {
            public void get()
            {
                Console.WriteLine("this is the get method implementation from interface");
            }
            public void print()
            {

            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                IPrint print = new Customer();
                print.print();
                ICricket cricket = new Customer();
                cricket.runs();
                cricket.wicket();
                IPrint get = new Student();
                get.get();

            }
        }
    }

    