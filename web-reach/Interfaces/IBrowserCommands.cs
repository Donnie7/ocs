namespace web_reach.Interfaces;

public interface IBrowserCommands
{
    Task OpenOgame();
    Task Login();
    Task CloseOGame();
}