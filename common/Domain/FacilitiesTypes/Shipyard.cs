namespace common.Domain.FacilitiesTypes;

using Interfaces;

public class Shipyard : IUpgrade
{
    public int Level { get; set; }
    public Task UpgradeLevel()
    {
        throw new NotImplementedException();
    }

    public Task CancelUpgrade()
    {
        throw new NotImplementedException();
    }
}