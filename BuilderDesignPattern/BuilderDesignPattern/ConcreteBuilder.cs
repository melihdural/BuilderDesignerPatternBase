namespace BuilderDesignPattern;

public class ConcreteBuilder : IBuilder
{
    private ProductA _productA;
    public void BuildPart()
    {
        _productA = new ProductA("ProductA");
        GetResult(_productA);
    }

    ProductA GetResult(ProductA a)
    {
        return a;
    }
}