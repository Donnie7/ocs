namespace common.Domain.ResourceTypes;

using Interfaces;

public class MetalMine : IUpgrade
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