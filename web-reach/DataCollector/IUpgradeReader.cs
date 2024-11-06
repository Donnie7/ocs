namespace web_reach.DataCollector;

using LanguageExt;

public interface IUpgradeReader
{
   Option<int> ReadCurrentLevel { get; set; }
   Option<int> ReadNextLevel { get; set; }
   Option<DateTime> ReadStartTime { get; set; }
   Option<DateTime> ReadEndTime { get; set; }
}