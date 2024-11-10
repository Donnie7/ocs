namespace control_station.ConsoleMenu.Commands;

using common.Kafka;
using common.Kafka.Commands.Browser;
using Interfaces;

public class BrowserCommands :  IBrowserCommands
{
    private readonly IKafkaProducer producer;
    
    public BrowserCommands(IKafkaProducer producer)
    {
        this.producer = producer;
    }
    
    public Task OpenOGame() => producer.SendCommand(new OpenOGameCommand());

    public Task Login() => producer.SendCommand(new LoginCommand());

    public Task CloseOGame() => producer.SendCommand(new CloseOGameCommand());
}