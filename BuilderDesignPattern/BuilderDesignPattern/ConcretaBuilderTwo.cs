namespace BuilderDesignPattern;

public class ConcretaBuilderTwo : IBuilder
{
    public void BuildPart()
    {
        GetResult();
    }

    void GetResult()
    {
        Console.WriteLine("b");
    }
}