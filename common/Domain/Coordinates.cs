namespace common.Domain;

using System.Text.RegularExpressions;
using MessagePack;

[MessagePackObject]
public partial class Coordinates
{
    [Key(0)]
    public int Galaxy { get; set; }
    [Key(1)]
    public int System { get; set; }
    [Key(2)]
    public int PlanetNumber { get; set; }

    [SerializationConstructor]
    public Coordinates()
    {
        
    } 
    
    public Coordinates(string coordinates)
    {
        var match = CoordinatesRegex().Match(coordinates);
        
        if (match.Success)
        {
            Galaxy = int.Parse(match.Groups[1].Value);
            System = int.Parse(match.Groups[2].Value);
            PlanetNumber = int.Parse(match.Groups[3].Value);
        }
        else
        {
            throw new FormatException("Invalid coordinate format");
        }
    }

    [GeneratedRegex(@"\[(\d+):(\d+):(\d+)\]")]
    private static partial Regex CoordinatesRegex();
}