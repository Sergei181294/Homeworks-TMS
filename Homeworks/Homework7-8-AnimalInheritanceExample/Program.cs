

namespace Homework7_8_AnimalInheritanceExample
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the dog's name: ");
            string dogName = Console.ReadLine();

            Dog dog = new Dog();
            dog.SetName(dogName);

            Console.WriteLine("The name of the dog is " + dog.GetName());
            dog.Eat();
        }
    }
}