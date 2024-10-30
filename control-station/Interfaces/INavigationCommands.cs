namespace control_station;

public interface INavigationCommands
{
    Task Overview();
    Task Resources();
    Task Lifeform();
    Task Facilities();
    Task Merchant();
    Task Research();
    Task Shipyard();
    Task Defense();
    Task Fleet();
    Task Galaxy();
    Task Empire();
    Task Alliance();
}