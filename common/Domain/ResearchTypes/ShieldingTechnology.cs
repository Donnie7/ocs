namespace common.Domain.ResearchTypes;

using Interfaces;

public class ShieldingTechnology : IUpgrade, IUpgradable
{
    public int Level { get; set; }
    public bool IsUpgrading { get; set; }

    public Task UpgradeLevel()
    {
        throw new NotImplementedException();
    }

    public Task CancelUpgrade()
    {
        throw new NotImplementedException();
    }
}