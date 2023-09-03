using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //parameterized
    internal class Person
    {
        public string name;
        public int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    //default
    internal class Car
    {
        string color = "blue";
        int speed = 130;
        public Car()
        {
            Console.WriteLine(color);
        }

    }

















}



