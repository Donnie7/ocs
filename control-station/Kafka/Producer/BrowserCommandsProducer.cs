namespace control_station.Kafka.Producer;

using common.Kafka;
using common.Kafka.Commands.Browser;
using Interfaces;

public class BrowserCommandsProducer :  IBrowserCommands
{
    private readonly IKafkaProducer producer;
    
    public BrowserCommandsProducer(IKafkaProducer producer)
    {
        this.producer = producer;
    }
    
    public Task OpenOGame() => producer.SendCommand(new OpenOGameCommand());

    public Task Login() => producer.SendCommand(new LoginCommand());

    public Task CloseOGame() => producer.SendCommand(new CloseOGameCommand());
}