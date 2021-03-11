using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bojko_Tarasenko_exam.Classes
{
    [Serializable()]
    public class Player
    {
        private bool[] _freezeParam;
        private string _name;       // Имя
        private float _satiety;       // Сытость
        private float _cheerfulness;  // Бодрость
        private float _hygiene;       // Гигиена
        private float _intelligence;  // Интеллект
        private float _mood;          // Настроение
        private float _health;        // Здоровье
        private int _money;           // Деньги
        public Study study;           // Учеба
        public Work work;             // Работа
        public string Name { get { return _name; } set { _name = value; } }
        public float Satiety { get { return _satiety; } set { _satiety = CheckVal(_satiety, value, 0); } }
        public float Cheerfulness { get { return _cheerfulness; } set { _cheerfulness = CheckVal(_cheerfulness, value, 1); } }
        public float Hygiene { get { return _hygiene; } set { _hygiene = CheckVal(_hygiene, value, 2); } }
        public float Intelligence { get { return _intelligence; } set { _intelligence = CheckVal(_intelligence, value, 3); } }
        public float Mood { get { return _mood; } set { _mood = CheckVal(_mood, value, 4); } }
        public float Health { get { return _health; } set { _health = CheckValHealth(value); } }
        public int Money { get { return _money; } set { if (value < 0) _money = 0; else _money = value; } }
        public DateTime gameTime;
        public InteractionItem fridge;

        public Player(string name="Noname", 
                        float satiety=100,
                        float cheerfulness =100,
                        float hygiene =100,
                        float intelligence =100,
                        float mood =100,
                        float health =100,
                        int money = 1000)
        {
            Name = name;
            _freezeParam = new bool[5] { false, false, false, false, false };
            Satiety = satiety;
            Cheerfulness = cheerfulness;
            Hygiene = hygiene;
            Intelligence = intelligence;
            Mood = mood;
            Health = health;
            Money = money;
            study = new Study();
            work = new Work();
        }
        private float CheckValHealth(float val)
        {
            if (val < 0) return 0;
            else if (val > 100) return 100;
            else return val;
        }
        private float CheckVal(float oldVal, float newVal, int paramNum)
        {
            if(newVal> oldVal)
            {
                _freezeParam[paramNum] = true;
                if (newVal < 0) return 0;
                else if (newVal > 100) return 100;
                else return newVal;
            }
            else
            {
                if (_freezeParam[paramNum])
                {
                    _freezeParam[paramNum] = false;
                    return oldVal;
                }
                else
                {
                    if (newVal < 0) return 0;
                    else if (newVal > 100) return 100;
                    else return newVal;
                }
            }
        }
        public void ChangeParams(
                        float satietyDelta,
                        float cheerfulnessDelta,
                        float hygieneDelta,
                        float intelligenceDelta,
                        float moodDelta,
                        float healthDelta,
                        int moneyDelta
                        )
        {
            Satiety += satietyDelta;
            Cheerfulness += cheerfulnessDelta;
            Hygiene += hygieneDelta;
            Intelligence += intelligenceDelta;
            Mood += moodDelta;
            Health += healthDelta;
            Money += moneyDelta;
        }
        public void GetMark()
        {
            study.AddMark(Intelligence);
        }
    }
}
