namespace control_station.Interfaces;

public interface IOgameCommands
{
    Task OpenOGame();
    Task Login();
    Task CloseOGame();
}