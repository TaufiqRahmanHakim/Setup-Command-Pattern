using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private ICommand walkCommand;
    private ICommand runCommand;
    private ICommand dashCommand;

    private Player player;

    void Start()
    {
        player = new Player();
        walkCommand = new WalkCommand(player);
        runCommand = new RunCommand(player);
        dashCommand = new DashCommand(player);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            walkCommand.Execute();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            runCommand.Execute();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            dashCommand.Execute();
        }
    }
}
