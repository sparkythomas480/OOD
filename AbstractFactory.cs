namespace AbstractFactory;

public abstract class AbstractProductA
{

}

public sealed class ProductA1 : AbstractProductA
{

}

public sealed class ProductA2 : AbstractProductA
{

}

public abstract class AbstractProductB
{

}

public sealed class ProductB1 : AbstractProductB
{

}

public sealed class ProductB2 : AbstractProductB
{
    
}

public abstract class AbstractFactory
{
    public abstract AbstractProductA CreateProductA();
    public abstract AbstractProductB CreateProductB();
}

public sealed class ConcreteFactory1 : AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        return new ProductA1();
    }

    public override AbstractProductB CreateProductB()
    {
        return new ProductB1();
    }
}

public sealed class ConcreteFactory2 : AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        return new ProductA2();
    }

    public override AbstractProductB CreateProductB()
    {
        return new ProductB2();
    }
}
