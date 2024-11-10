namespace common.Domain.LifeformTypes;

using Interfaces;

public class NeuroCalibrationCentre : IUpgrade
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