using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatanBoardGenerator.Models
{
    public class Board
    {
        public List<Hex> theHexes;
        //public List<Corner> theCorners;
        char[] locations = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S' };
        public Board()   //Create random board
        {
            theHexes = new List<Hex>();
            string[] terrains = { "Hills", "Hills", "Hills", "Forest", "Forest", "Forest", "Forest", "Mountains", "Mountains", "Mountains", "Fields", "Fields", "Fields", "Fields", "Pasture", "Pasture", "Pasture", "Pasture", "Desert" };
            ArrayList lTerrains = new ArrayList(terrains);
            int[] numbers = { 2, 3, 3, 4, 4, 5, 5, 6, 6, 8, 8, 9, 9, 10, 10, 11, 11, 12 };
            ArrayList lNumbers = new ArrayList(numbers);

            Random rnd = new Random();
            int r;
            for (int i = 0; i < locations.Length; i++)
            {
                char location = locations[i];

                r = rnd.Next(lTerrains.Count);
                string terrain = (string)lTerrains[r];
                lTerrains.RemoveAt(r);

                if (terrain.Equals("Desert"))
                {
                    Hex hex = new Hex(location, "Desert");
                    theHexes.Add(hex);
                }
                else
                {
                    r = rnd.Next(lNumbers.Count);
                    int number = (int)lNumbers[r];
                    lNumbers.RemoveAt(r);
                    Hex hex = new Hex(location, terrain, number);
                    theHexes.Add(hex);
                }
            }
            //theCorners = generateCorners(theHexes);
        }
    }
}