using System;
using System.Linq;

namespace PartyThyme
{
  class Program
  {
    static void Main(string[] args)
    {

      {
        var isRunning = true;
        while (isRunning)
        {
          var db = new PlantContext();
          var newPlant = new Plant();
          Console.WriteLine("welcome to the garden!");
          Console.WriteLine("would you like to (A)dd a plant, (R)emove a plant, or (U)pdate a plant?");
          var input = Console.ReadLine().ToLower();

          if (input == "a")
          {
            Console.WriteLine($"plant species?");
            newPlant.Species = Console.ReadLine();
            Console.WriteLine($"Where is your plant located?");
            newPlant.LocatedPlanted = Console.ReadLine();
            Console.WriteLine($"how much light does your plant need?");
            newPlant.LightNeeded = Console.ReadLine();
            Console.WriteLine("how often does your plant need to be watered?");
            newPlant.WaterNeeded = Console.ReadLine();
            newPlant.LastWateredDate = DateTime.Now;
            newPlant.PlantDate = DateTime.Now;
            db.plants.Add(newPlant);
            db.SaveChanges();
          }
          else if (input == "r")
          {
            Console.WriteLine("Which plant would you like to delete?");
            var plantToDelete = Console.ReadLine();

            var toDelete = db.plants.FirstOrDefault(p => p.Species == plantToDelete);

            if (toDelete != null)
            {
              db.plants.Remove(toDelete);
              db.SaveChanges();
            }
            else
            {
              Console.WriteLine("Plant not found.");
            }
          }
          // else if (input == "u") ;
          // {
          //   Console.WriteLine("Which plant would you like to update?");

          //   var plantToUpdate = Console.ReadLine();

          //   var toUpdate = db.plants.FirstOrDefault(p => p.Species == plantToUpdate);
          //   if (toUpdate != null)
          //   {
          //     db.plants.Remove(toUpdate);
          //     db.SaveChanges();
          //   }
          //   else
          //   {
          //     Console.WriteLine("Plant not found.");
          //   }

          //   Console.WriteLine($"what would you like to change about this plant? The (water) it needs, or how much (light) this plant needs?");

          //   var update = Console.ReadLine().ToLower;

          // if (update == "water")
          // {
          //   Console.WriteLine($"how much water does {plantToUpdate} need?");
          //   var waterNeed = Console.ReadLine();
          //   toUpdate.WaterNeeded = waterNeed;
          //   db.plants.Update(toUpdate);
          // }
          // if (update == "light")
          // {
          //   Console.WriteLine($"how much water does {plantToUpdate} need?");
          //   var lightNeed = Console.ReadLine();
          //   toUpdate.LightNeeded = lightNeed;
          //   db.plants.Update(toUpdate);
          // }
          // db.SaveChanges();
          // var displayAll = db.plants.OrderBy(P => P.LastWateredDate);
          // foreach (var Plant in displayAll)
          // {
          //   Console.WriteLine($"{Plant.Id}: {Plant.Species} was last watered on {Plant.LastWateredDate}.");
          // }
          // Console.WriteLine("What plant would you like to water? Please enter the plant id from the list above!");
          // var userWater = Console.ReadLine().ToLower;
          // var plantToWater = db.plants.FirstOrDefault(Plant => Plant.Id == userWater);
          // plantToWater.LastWateredDate = DateTime.Now;
          // db.SaveChanges();
          Console.WriteLine("Would you like to plant another plant?");
          var whileLoop = Console.WriteLine();
          if (whileLoop == "yes")
          {
            isRunning = true;
          }
          else if (whileLoop == "no")
          {
            isRunning = false;
          }
        }
      }
    }
  }
}