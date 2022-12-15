namespace BuilderDesignPattern;

public class Client
{ 
    internal void Order()
    {
        //TODO - define a director to manage orders
        Director director = new Director();
        
        //TODO - define builder to director need
        IBuilder builder = new ConcreteBuilder();
        IBuilder builderTwo = new ConcretaBuilderTwo();
        
        //TODO - tell director which product you wish
        director.Construct(builder);
        Console.WriteLine("*********************");
        director.Construct(builderTwo);
    }

}