public class WalkCommand : ICommand
{
    private Player player;

    public WalkCommand(Player player)
    {
        this.player = player;
    }

    public void Execute()
    {
        player.Walk();
    }
}

public class RunCommand : ICommand
{
    private Player player;

    public RunCommand(Player player)
    {
        this.player = player;
    }

    public void Execute()
    {
        player.Run();
    }
}

public class DashCommand : ICommand
{
    private Player player;

    public DashCommand(Player player)
    {
        this.player = player;
    }

    public void Execute()
    {
        player.Dash();
    }
}
