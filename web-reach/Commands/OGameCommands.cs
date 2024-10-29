namespace web_reach.Commands;

using OpenQA.Selenium;
using Selelium;

public class OGameCommands : SeleniumWebDriver, IOgame
{
    private const string OgameURL = "https://lobby.ogame.gameforge.com/pt_PT/";
    private const string LoginTab = "//*[@id=\"loginRegisterTabs\"]/ul/li[1]";
    private const string Email = "alt.mail.16@gmail.com";
    private const string EmailXPath = "//*[@id=\"loginForm\"]/div[2]/div/input";
    private const string Password = "naosei_534";
    private const string PasswordXPath = "//*[@id=\"loginForm\"]/div[3]/div/input";
    private const string LoginButtonXPath = "//*[@id=\"loginForm\"]/p/button[1]";
    private const string LastSession = "//*[@id=\"joinGame\"]/button";

    public Task OpenOgame()
    {
        try
        {
            Driver.Url = OgameURL;
        }
        catch (Exception)
        {
            Driver = InitDriver();
            Driver.Url = OgameURL;
        }
        return Task.CompletedTask;
    }

    public Task Login()
    {
        Driver.FindElement(By.XPath(LoginTab)).Click();
        Driver.FindElement(By.XPath(EmailXPath)).SendKeys(Email);
        Driver.FindElement(By.XPath(PasswordXPath)).SendKeys(Password);
        Driver.FindElement(By.XPath(LoginButtonXPath)).Click();
        WaitUntilAvailable(By.XPath(LastSession)); 
        Driver.FindElement(By.XPath(LastSession)).Click();

        // just a test
        Thread.Sleep(10000);
        SwitchToWindow("Himalia OGame");
        Driver.FindElement(By.XPath("//*[@id=\"menuTable\"]/li[2]/a")).Click();
        return Task.CompletedTask;
    }

    public Task CloseOGame()
    {
        Driver.Close();
        return Task.CompletedTask;
    }
}