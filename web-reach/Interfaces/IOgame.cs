namespace web_reach;

public interface IOgame
{
    Task OpenOgame();
    Task Login();
    Task CloseOGame();
}