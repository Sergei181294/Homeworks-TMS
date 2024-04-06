

namespace Homework7_8_AnimalInheritanceExample
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName() => Name;

        public abstract void Eat();
    }

    
}
