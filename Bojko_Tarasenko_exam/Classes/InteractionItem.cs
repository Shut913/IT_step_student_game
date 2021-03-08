using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bojko_Tarasenko_exam.Classes
{
    public class InteractionItem
    {
        public string Name { get; private set; }
        public Position _posUpperLeft;
        public Position _posBottomRight;
        public List<Interaction> _interactions;
        public InteractionItem(string name, int xStart, int yStart, int xEnd, int yEnd, List<Interaction> interactions)
        {
            Name = name;
            _posUpperLeft = new Position(xStart, yStart);
            _posBottomRight = new Position(xEnd, yEnd);
            _interactions=interactions;
        }
    }
}
