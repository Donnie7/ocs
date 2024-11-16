namespace common.Domain.DefenceTypes;

using Interfaces;

public class SmallShieldDome : IUpgrade
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