using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bojko_Tarasenko_exam.Classes
{
    [Serializable()]
    public class Interaction
    {
        public string _text;
        public List<Impact> _impact;
        public Interaction(string text, List<Impact> impact) 
        {
            _text = text;
            _impact = impact;
        }
    }
}
