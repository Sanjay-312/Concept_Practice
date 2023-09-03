namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //contructors
            //Person P = new Person("sanjay", 25);
            //Console.WriteLine(P.name);
            //Car audi = new Car();

            //interfaces
            Animal A;
            A = new Dog();
            A.makeSound();
            A = new Cat();
            A.makeSound();


        }
    }
}