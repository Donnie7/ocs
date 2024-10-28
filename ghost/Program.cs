namespace ghost;

using Kafka;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Program
{
    static async Task Main()
    {
        var host = CreateHostBuilder().Build();

        await host.RunAsync();
    }

    public static IHostBuilder CreateHostBuilder() =>
        Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
                {
                    services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
                    services.AddHostedService<KafkaConsumerService>();
                })
            .ConfigureAppConfiguration((builderContext, config) =>
            {
                var env = builderContext.HostingEnvironment;
                config
                    .AddJsonFile("conf/appsettings.json", optional: false, reloadOnChange: true)
                    .AddJsonFile($"conf/appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                    .AddEnvironmentVariables();
            });
}
/*
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

var driver = new ChromeDriver();
driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
driver.Url = "https://lobby.ogame.gameforge.com/pt_PT/";
var element = driver.FindElement(By.XPath("//*[@id=\"loginRegisterTabs\"]/ul/li[1]"));
element.Click();
driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/div[2]/div/input")).SendKeys("alt.mail.16@gmail.com");
driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/div[3]/div/input")).SendKeys("naosei_534");
driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/p/button[1]")).Click();
driver.Quit();
*/