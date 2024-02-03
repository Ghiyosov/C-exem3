namespace Task6;

public class Cat : Animal
{
    public Cat(string name):base(name) 
    {
        
    }
    public override void greats()
    {
        System.Console.WriteLine("Meow");
    }
}
