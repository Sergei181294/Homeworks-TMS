

namespace Homework7_8_AnimalInheritanceExample
{
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The dog named " + Name + " is eating.");
        }
    }
}
