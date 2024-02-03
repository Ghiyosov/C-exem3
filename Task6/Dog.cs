using System.Net.Http.Headers;

namespace Task6;

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
        
    }
    public override void greats()
    {
        System.Console.WriteLine("Woof");
    }
    public virtual void greats(Dog another)
    {
        System.Console.WriteLine("Wooof");
    }
}
