namespace ISP;

public interface IWorker
{
    void Work();
    void Eat();
    void Sleep();
}

public class HumanWorker : IWorker
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void Sleep()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}

public class RobotWorker : IWorker
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void Sleep()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}

public interface IWorker2
{
    void Work();
}

public interface IEater
{
    void Eat();
}

public class HumanWorker2 : IEater, IWorker2
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}

public class RobotWorker2 : IWorker2
{
    public void Work()
    {
        throw new NotImplementedException();
    }
}
