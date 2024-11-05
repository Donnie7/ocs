namespace web_reach.Commands;

using Interfaces;
using OpenQA.Selenium;
using Selenium;

public class BrowserCommands(ISeleniumWebDriver driver) : SeleniumCommand(driver), IBrowserCommands
{
    private const string OgameUrl = "https://lobby.ogame.gameforge.com/pt_PT/";
    private const string LoginTab = "//*[@id=\"loginRegisterTabs\"]/ul/li[1]";
    private const string Email = "alt.mail.16@gmail.com";
    private const string EmailXPath = "//*[@id=\"loginForm\"]/div[2]/div/input";
    private const string Password = "naosei_534";
    private const string PasswordXPath = "//*[@id=\"loginForm\"]/div[3]/div/input";
    private const string LoginButtonXPath = "//*[@id=\"loginForm\"]/p/button[1]";
    private const string LastSession = "//*[@id=\"joinGame\"]/button";

    public Task OpenOgame()
    {
        Driver.InitDriver();
        Driver.GoToURL(OgameUrl);
        return Task.CompletedTask;
    }

    public Task Login()
    {
        Driver.ClickButton(LoginTab);
        Driver.SendKeys(EmailXPath, Email);
        Driver.SendKeys(PasswordXPath, Password);
        Driver.ClickButton(LoginButtonXPath);
        Driver.WaitUntilAvailable(By.XPath(LastSession));
        Driver.ClickButton(LastSession);

        // just a test
        Thread.Sleep(10000);
        Driver.SwitchToWindow("Himalia OGame");
        return Task.CompletedTask;
    }

    public Task CloseOGame()
    {
        Driver.CloseOGame();
        return Task.CompletedTask;
    }
}