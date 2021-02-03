using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bojko_Tarasenko_exam.Classes
{
    class Player
    {
        private string _name;
        private int _satiety;
        private int _cheerfulness;
        private int _hygiene;
        private int _intelligence;
        private int _mood;
        private int _money;
        public string Name { get { return _name; } set { _name = value; } }
        public int Satiety { get { return _satiety; } set { _satiety = CheckVal(value); } }
        public int Cheerfulness { get { return _cheerfulness; } set { _cheerfulness = CheckVal(value); } }
        public int Hygiene { get { return _hygiene; } set { _hygiene = CheckVal(value); } }
        public int Intelligence { get { return _intelligence; } set { _intelligence = CheckVal(value); } }
        public int Mood { get { return _mood; } set { _mood = CheckVal(value); } }
        public int Money { get { return _money; } set { if (value < 0) _money = 0; else _money = value; } }

        public Player(string name="Noname", 
                        int satiety=100, 
                        int cheerfulness=100, 
                        int hygiene=100,
                        int intelligence=100,
                        int mood=100,
                        int money = 1000)
        {
            Name = name;
            Satiety = satiety;
            Cheerfulness = cheerfulness;
            Hygiene = hygiene;
            Intelligence = intelligence;
            Mood = mood;
            Money = money;
        }

        private int CheckVal(int val)
        {
            if (val < 0) return 0;
            else if (val > 100) return 100;
            else return val;
        }
    }
}
