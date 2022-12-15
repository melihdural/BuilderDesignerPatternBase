namespace BuilderDesignPattern;

public class Client
{ 
    internal void Order()
    {
        Director director = new Director();
        IBuilder builder = new ConcreteBuilder();
        IBuilder builderTwo = new ConcretaBuilderTwo();
        director.Construct(builder);
        Console.WriteLine("*********************");
        director.Construct(builderTwo);
    }

}