﻿namespace common.Domain.ResourceTypes;

using Interfaces;

public class DeutheriumSynthesizer : IUpgrade
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