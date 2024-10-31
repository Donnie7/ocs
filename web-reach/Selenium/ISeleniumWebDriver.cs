namespace web_reach.Selenium;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public interface ISeleniumWebDriver
{
    Task WaitUntilAvailable(By by);
    Task SwitchToWindow(string title);
    ChromeDriver InitDriver();
    Task GoToURL(string url);
    Task ClickButton(string buttonXPath);
    Task SendKeys(string inputXPath, string keys);
    Task CloseOGame();
}