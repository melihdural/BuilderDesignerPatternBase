namespace BuilderDesignPattern;

public class ConcretaBuilderTwo : IBuilder
{
    private ProductB _productB;
    public void BuildPart()
    {
        //TODO - call the product under builder's responsibility
        _productB = new ProductB("ProductB");
        
        //TODO - return product result to director
        GetResult(_productB);
    }

    ProductB GetResult(ProductB b)
    {
        return b;
    }
}