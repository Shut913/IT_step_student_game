using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bojko_Tarasenko_exam.Classes
{
    public class GameLocation
    {
        public string Name { get; set; }
        public List<InteractionItem> _interactionItems;
        public string _image;
        public GameLocation(string name, string image, List<InteractionItem> interactionItems)
        {
            Name = name;
            _interactionItems=interactionItems;
            _image = image;
        }
    }
}
