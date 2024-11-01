namespace control_station.Commands;

using common.Kafka;
using common.Kafka.Commands.Browser;
using Interfaces;

public class BrowserCommandsProducer :  IBrowserCommands
{
    private readonly IKafkaCommandProducer producer;
    
    public BrowserCommandsProducer(IKafkaCommandProducer producer)
    {
        this.producer = producer;
    }
    
    public Task OpenOGame() => producer.SendCommand(new OpenOGameCommand());

    public Task Login() => producer.SendCommand(new LoginCommand());

    public Task CloseOGame() => producer.SendCommand(new CloseOGameCommand());
}