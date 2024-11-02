namespace ghost.Interfaces;

using common.Kafka.Commands;

public interface INavigationController
{
   Task Execute(ICommand command);
   Task Navigate();
   Task<NavigationResult> CollectData();
}

public class NavigationResult
{
}