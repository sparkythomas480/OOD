namespace FactoryMethod;

public abstract class Product
{
}

public sealed class ConcreteProduct : Product
{
}

public abstract class Creator
{
    public abstract Product FactoryMethod();
}

public sealed class ConcreteCreator : Creator
{
    public override Product FactoryMethod()
    {
        return new ConcreteProduct();
    }
}
