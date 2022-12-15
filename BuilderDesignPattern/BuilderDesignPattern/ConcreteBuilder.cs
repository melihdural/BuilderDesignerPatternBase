namespace BuilderDesignPattern;

public class ConcreteBuilder : IBuilder
{
    public void BuildPart()
    {
        GetResult();
    }

    void GetResult()
    {
        Console.WriteLine("a");
    }
}