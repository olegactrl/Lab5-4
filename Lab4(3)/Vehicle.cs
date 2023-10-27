using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3_
{
    public internal class Vehicle : IDriveable
    {
        public int Speed {  get; set; }
        public int Size {  get; set; }
        public string Type {  get; set; }
        public int CarQuality { get; set; }

        public Vehicle(int speed, int size, string type, int quality) 
        { 
            this.Speed = speed;
            this.Size = size;
            this.Type = type;
            this.CarQuality = quality;
        }
        public void Move() { }
    }
}
