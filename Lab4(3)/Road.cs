using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3_
{
    public class Road
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Line { get; set; }
        public int RoadQuality { get; set; }

        public Road(int length, int width, int line, int roadQuality)
        {
            this.Length = length;
            this.Width = width;
            this.Line = line;
            this.RoadQuality = roadQuality;
        }
    }
}
