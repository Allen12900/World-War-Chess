using System;
using System.Collections.Generic;
using System.Text;

namespace World_War_Chess
{
    public class Pieces
    {
        public string name { get; set; }
        public int health { get; set; }
        public int attack {get; set; }
        public int moveDistance { get; set; }
        public int killDistace { get; set; }
        public bool isWhite { get; set; }
    }
}
