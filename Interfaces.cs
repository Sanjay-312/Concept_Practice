using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    interface Animal
    {
        void makeSound();
    }

    public class Cat : Animal
    {
        public void makeSound()
        {
            Console.WriteLine("cat sounds meow meow");
        }
    }

    public class Dog : Animal
    {
        public void makeSound()
        {
            Console.WriteLine("dog souns bow bow");
        }
    }

}
