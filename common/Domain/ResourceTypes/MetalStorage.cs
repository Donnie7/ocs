namespace common.Domain.ResourceTypes;

using Interfaces;

public class MetalStorage : IUpgrade
{
    public int Level { get; set; }
}