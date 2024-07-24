namespace Builder;

public class Product
{
    private List<string> parts = new List<string>();

    public void Add(string part)
    {
        parts.Add(part);
    }
}

public abstract class Builder
{
    protected Product product = new Product();

    public abstract Builder BuildPartA();
    public abstract Builder BuildPartB();
    public Product ToProduct()
    {
        return product;
    }
}

public sealed class ConcreteBuilder1 : Builder
{
    public override Builder BuildPartA()
    {
        product.Add("PartA1");
        return this;
    }

    public override Builder BuildPartB()
    {
        product.Add("PartB1");
        return this;
    }
}

public sealed class ConcreteBuilder2 : Builder
{
    public override Builder BuildPartA()
    {
        product.Add("PartA2");
        return this;
    }

    public override Builder BuildPartB()
    {
        product.Add("PartB2");
        return this;
    }
}

public class Director
{
    public Product Construct(Builder builder)
    {
        return builder.BuildPartA().BuildPartB().ToProduct();
    }
}