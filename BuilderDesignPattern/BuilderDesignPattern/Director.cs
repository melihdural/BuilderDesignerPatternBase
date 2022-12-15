namespace BuilderDesignPattern;

public class Director
{
    internal void Construct(IBuilder builder)
    {
        //TODO - tell builders what to do
        builder.BuildPart();
    }
}