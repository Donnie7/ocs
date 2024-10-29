namespace control_station.Commands;

using Kafka;

public class OGameCommands(KafkaJsonProducer kafkaProducer) : KafkaCommand(kafkaProducer), IOgameCommands
{
    public Task OpenOGame()
    {
        return SendCommand("Open OGame");
    }

    public Task Login()
    {
        return SendCommand("Login");
    }

    public Task CloseOGame()
    {
        return SendCommand("Close Ogame");
    }
}