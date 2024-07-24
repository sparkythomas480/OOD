namespace Prototype;

public abstract class Prototype
{
    public abstract Prototype Clone();
}

public sealed class ConcretePrototype1 : Prototype
{
    int myFavouriteInt;

    public ConcretePrototype1(int myFavouriteInt)
    {
        this.myFavouriteInt = myFavouriteInt;
    }

    public override Prototype Clone()
    {
        return (ConcretePrototype1)this.MemberwiseClone();
    }
}

public sealed class ConcretePrototype2 : Prototype
{
    double myFavouriteDouble;

    public ConcretePrototype2(double myFavouriteDouble)
    {
        this.myFavouriteDouble = myFavouriteDouble;
    }

    public override Prototype Clone()
    {
        return (ConcretePrototype2)this.MemberwiseClone();
    }
}