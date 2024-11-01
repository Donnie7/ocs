namespace control_station.Commands;

using busCommands.Browser;
using Interfaces;
using Kafka;

public class BrowserCommands(KafkaJsonProducer kafkaProducer) : KafkaCommand(kafkaProducer), IOgameCommands
{
    public Task OpenOGame() => SendCommand(new OpenOGameCommand());

    public Task Login() => SendCommand(new LoginCommand());

    public Task CloseOGame() => SendCommand(new CloseOGameCommand());
}