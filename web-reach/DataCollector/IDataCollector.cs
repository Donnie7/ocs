namespace web_reach.DataCollector;

public interface IDataCollector<T>
{
    public Task<T> Collect();
}