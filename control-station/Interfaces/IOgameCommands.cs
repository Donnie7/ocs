namespace control_station;

public interface IOgameCommands
{
    Task OpenOGame();
    Task Login();
    Task CloseOGame();
}