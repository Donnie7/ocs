namespace web_reach.Interfaces;

public interface IOgameCommands
{
    Task OpenOgame();
    Task Login();
    Task CloseOGame();
}