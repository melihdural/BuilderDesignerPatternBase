namespace BuilderDesignPattern;

public class Director
{
    internal void Construct(IBuilder builder)
    {
        builder.BuildPart();
    }
}