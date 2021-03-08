﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bojko_Tarasenko_exam.Classes
{
    public enum Characteristic
    {
        satiety,            // Сытость
        cheerfulness,       // Бодрость
        hygiene,            // Гигиена
        intelligence,       // Интеллект
        mood,               // Настроение
        money,              // Деньги
        time,               // Время
        location,           // Локация
        mark,               // Оценка
        buyFood,            // Покупка еды
        eatFood             // Кушание еды
    }
    public struct Impact
    {
        public Characteristic characteristic;
        public int value;
        public Impact(Characteristic _characteristic, int _value)
        {
            characteristic = _characteristic;
            value = _value;
        }
    }
    public struct Position
    {
        public int X;
        public int Y;
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    public enum GLocations
    {
        park=0,
        bedroom,
        kitchen,
        bathroom,
        work,
        shop,
        map,
        academy
    }
}
