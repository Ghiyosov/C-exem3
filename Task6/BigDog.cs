namespace Task6;

public class BigDog : Dog
{
    public BigDog(string name) : base(name)
    {
        
    }
    public override void greats()
    {
        System.Console.WriteLine("Wooow");
    }
    public override void greats(Dog another)
    {
        System.Console.WriteLine("Woooooow");
    }
    public void greats(BigDog another)
    {
        System.Console.WriteLine("Woooooooooooow");
    }
}
