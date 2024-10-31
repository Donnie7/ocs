namespace control_station.Commands;

using global::Commands.Browser;
using Interfaces;
using Kafka;

public class BrowserCommands(KafkaJsonProducer kafkaProducer) : KafkaCommand(kafkaProducer), IOgameCommands
{
    public Task OpenOGame()
    {
        return SendCommand(new OpenOGameCommand());
    }

    public Task Login()
    {
        return SendCommand(new LoginCommand());
    }

    public Task CloseOGame()
    {
        return SendCommand(new CloseOGameCommand());
    }
}