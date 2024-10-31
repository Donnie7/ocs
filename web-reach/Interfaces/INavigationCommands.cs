namespace web_reach.Interfaces;

public interface INavigationCommands
{
    Task Alliance();
    Task Defense();
    Task Empire();
    Task Facilities();
    Task Fleet();
    Task Galaxy();
    Task Lifeform();
    Task Merchant();
    Task Overview();
    Task Research();
    Task Resources();
    Task Shipyard();
}