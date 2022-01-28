using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)

        
        {
            
            List<string> videogame = new List<string>() { "Grand Theft Auto", "GTA2", "GTA3","GTA4", "GTA5" };

            var gamelist = videogame.OrderBy(name => name.Length);

            foreach (var name in gamelist)
            {
                Console.WriteLine(name);
            }

           

        }
    }
}
