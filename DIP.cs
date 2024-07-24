namespace DIP;

public interface ICommand
{
    void Execute();
}

public class DIP : ICommand
{
    ICommand[] commands;
    public DIP(IEnumerable<ICommand> commands)
    {
        this.commands = commands.ToArray();
    }

    public void Execute()
    {
        foreach (var command in this.commands)
            command.Execute();
    }
}
