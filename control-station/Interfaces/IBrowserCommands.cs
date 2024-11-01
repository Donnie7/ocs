namespace control_station.Interfaces;

public interface IBrowserCommands
{
    Task OpenOGame();
    Task Login();
    Task CloseOGame();
}