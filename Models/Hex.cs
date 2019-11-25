using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatanBoardGenerator.Models
{
    public class Hex : IComparable<Hex>
    {
        public string terrain;
        public int spots;
        public char location;
        public int number;

        public Hex(char location, string terrain, int number)
        {
            this.location = location;
            this.terrain = terrain;
            this.number = number;
            switch (number)
            {
                case 2:
                    spots = 1;
                    break;
                case 3:
                    spots = 2;
                    break;
                case 4:
                    spots = 3;
                    break;
                case 5:
                    spots = 4;
                    break;
                case 6:
                    spots = 5;
                    break;
                case 8:
                    spots = 5;
                    break;
                case 9:
                    spots = 4;
                    break;
                case 10:
                    spots = 3;
                    break;
                case 11:
                    spots = 2;
                    break;
                case 12:
                    spots = 1;
                    break;
                default:
                    spots = 0;
                    break;
            }

        }
        public Hex(char location, string terrain)
        {
            this.location = location;
            this.terrain = terrain;
            spots = 0;
        }
        public int CompareTo(Hex other)
        {
            return this.location.CompareTo(other.location);
        }
        public override string ToString()
        {
            if (!terrain.Equals("Desert"))
            {
                return "location: " + location + " terrain: " + terrain + " number: " + number;
            }
            else
            {
                return "location: " + location + " terrain: " + terrain;
            }
        }

    }
}