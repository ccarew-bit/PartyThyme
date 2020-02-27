using System;

namespace PartyThyme
{
  public class Plant
  {
    public int Id { get; set; }

    public string Species { get; set; }

    public DateTime PlantDate { get; set; }

    public string LocatedPlanted { get; set; }

    public DateTime LastWateredDate { get; set; }

    public string LightNeeded { get; set; }

    public string WaterNeeded { get; set; }

  }
}