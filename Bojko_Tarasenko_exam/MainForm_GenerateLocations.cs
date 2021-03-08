using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bojko_Tarasenko_exam.Classes;

namespace Bojko_Tarasenko_exam
{
    public partial class MainForm : Form
    {
        private List<GameLocation> GenerateLocations()
        {
            return new List<GameLocation>{
                new GameLocation("Парк", "..\\..\\Images\\park.png", new List<InteractionItem> {    // 1. Парк
                    new InteractionItem("Голуби", 250, 250, 370, 320, new List<Interaction> {       // 1.1 Голуби
                        new Interaction("1. Покормить голубей   (B: 5 мин, Н: +3)", new List<Impact> {
                            new Impact(Characteristic.mood, 3),
                            new Impact(Characteristic.time, 5)
                        }),
                        new Interaction("2. Распугать   (В: 10 мин, Г: -2)", new List<Impact> {
                            new Impact(Characteristic.hygiene, -2),
                            new Impact(Characteristic.time, 10)
                        }),
                        new Interaction("3. Кинуть палку   (И: -7)", new List<Impact> {
                            new Impact(Characteristic.intelligence, -7)
                        }),
                        new Interaction("4. Позвать   (И: -3)", new List<Impact> {
                            new Impact(Characteristic.intelligence, -3)
                        }),
                        new Interaction("6. Поговорить по душам   (И: -5, Н: +5)", new List<Impact> {
                            new Impact(Characteristic.mood, 5),
                            new Impact(Characteristic.intelligence, -5)
                        })
                    }),
                    new InteractionItem("Фонтан", 615, 320, 810, 400, new List<Interaction> {       // 1.2 Фонтан
                        new Interaction("1. Попить воды   (В: 10 мин, И: -7, Н: +5)", new List<Impact> {
                            new Impact(Characteristic.intelligence, -7),
                            new Impact(Characteristic.mood, 5),
                            new Impact(Characteristic.time, 10)
                        }),
                        new Interaction("2. Искупаться   (В: 10 мин, Г: +5, И: -10, Н: +5)", new List<Impact> {
                            new Impact(Characteristic.intelligence, -10),
                            new Impact(Characteristic.hygiene, 5),
                            new Impact(Characteristic.mood, 5),
                            new Impact(Characteristic.time, 15)
                        }),
                        new Interaction("3. Плюнуть   (И: -10)", new List<Impact> {
                            new Impact(Characteristic.intelligence, -10)
                        })
                    }),
                    new InteractionItem("",439,386,489,436, new List<Interaction> {     // 1.3 Тропинка
                        new Interaction("1. Уйти из парка", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.map)),
                            new Impact(Characteristic.time, 5)
                        })
                    })
                }),
                new GameLocation("Спальня", "..\\..\\Images\\bedroom.png", new List<InteractionItem> {  // 2 Спальня
                    new InteractionItem("Коридор",297,398,346,447, new List<Interaction> {            // 2.1 Выход
                        new Interaction("1. Пойти на кухню", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.kitchen)),
                            new Impact(Characteristic.time, 5)
                        }),
                        new Interaction("2. Пойти в ванную комнату", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.bathroom)),
                            new Impact(Characteristic.time, 5)
                        }),
                        new Interaction("3. Выйти на улицу", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.map)),
                            new Impact(Characteristic.time, 5)
                        })
                    }),
                    new InteractionItem("Компьютер", 170, 215, 250, 280, new List<Interaction> {        // 2.2 Компьютер
                        new Interaction("1. Выполнить домашнее задание   ( В: 2 ч, И: +20, Н: -20)", new List<Impact> {
                            new Impact(Characteristic.mark, 0),
                            new Impact(Characteristic.time, 180),
                            new Impact(Characteristic.intelligence, 10),
                            new Impact(Characteristic.mood, -20)
                        })
                    }),
                    new InteractionItem("Книжная полка", 170, 100, 385, 150, new List<Interaction> {        // 2.3 Полка 1
                        new Interaction("1. Почитать художественную литературу   (В: 1 ч, Б: -15, И: +10, Н: +10)", new List<Impact> {
                            new Impact(Characteristic.time, 60),
                            new Impact(Characteristic.cheerfulness, -15),
                            new Impact(Characteristic.intelligence, 10),
                            new Impact(Characteristic.mood, 10)
                        }),
                        new Interaction("2. Почитать учебную литературу   (В: 1 ч, Б: -15, И: +15, Н: -5)", new List<Impact> {
                            new Impact(Characteristic.time, 60),
                            new Impact(Characteristic.cheerfulness, -15),
                            new Impact(Characteristic.intelligence, 15),
                            new Impact(Characteristic.mood, -5)
                        })
                    }),
                    new InteractionItem("Книжная полка", 390, 185, 610, 240, new List<Interaction> {        // 2.4 Полка 2
                         new Interaction("1. Почитать художественную литературу   (В: 1 ч, Б: -15, И: +10, Н: +10)", new List<Impact> {
                            new Impact(Characteristic.time, 60),
                            new Impact(Characteristic.cheerfulness, -15),
                            new Impact(Characteristic.intelligence, 10),
                            new Impact(Characteristic.mood, 10)
                        }),
                         new Interaction("2. Почитать учебную литературу   (В: 1 ч, Б: -15, И: +15, Н: -5)", new List<Impact> {
                            new Impact(Characteristic.time, 60),
                            new Impact(Characteristic.cheerfulness, -15),
                            new Impact(Characteristic.intelligence, 15),
                            new Impact(Characteristic.mood, -5)
                        })
                    }),
                    new InteractionItem("Кровать", 370, 350, 620, 410, new List<Interaction> {        // 2.5 Кровать
                        new Interaction("1. Выспаться   (В: 8 ч, Б: +100)", new List<Impact> {
                            new Impact(Characteristic.satiety, 100),
                             new Impact(Characteristic.time, 480),
                        }),
                        new Interaction("2. Спать   (В: 6 ч, Б: +70)", new List<Impact> {
                            new Impact(Characteristic.satiety, 70),
                             new Impact(Characteristic.time, 360),
                        }),
                        new Interaction("3. Вздремнуть   (В: 30 мин, Б: +25)", new List<Impact> {
                            new Impact(Characteristic.satiety, 25),
                             new Impact(Characteristic.time, 30),
                        })
                    }),
                    new InteractionItem("Записки", 260, 170, 355, 250, new List<Interaction> {        // 2.6 Записки
                        new Interaction("1. Посмотреть рассписание учебы   (В: 5 мин, И: +3)", new List<Impact> {
                            new Impact(Characteristic.time, 5),
                            new Impact(Characteristic.intelligence, 3)                            
                        }),
                         new Interaction("2. Посмотреть фотографии   (В: 5 мин, Н: +10)", new List<Impact> {
                            new Impact(Characteristic.time, 5),
                            new Impact(Characteristic.mood, 10)
                        })
                    }),
                    new InteractionItem("Окно", 1, 100, 140, 260, new List<Interaction> {        // 2.7 Окно
                        new Interaction("1. Посмотреть в окно (В: 10 мин, И: +5, Н: +10)", new List<Impact> {
                            new Impact(Characteristic.time, 10),
                            new Impact(Characteristic.intelligence, 5),
                            new Impact(Characteristic.mood, 10)
                        })
                    })
                }),
                new GameLocation("Кухня", "..\\..\\Images\\kitchen.png", new List<InteractionItem> {    // 3 Кухня
                    new InteractionItem("Коридор", 414,394,460,443, new List<Interaction> {            // 3.1 Выход
                        new Interaction("1. Пойти в спальню", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.bedroom)),
                            new Impact(Characteristic.time, 5)
                        }),
                        new Interaction("2. Пойти в ванную комнату", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.bathroom)),
                            new Impact(Characteristic.time, 5)
                        }),
                        new Interaction("3. Выйти на улицу", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.map)),
                            new Impact(Characteristic.time, 5)
                        })
                    }),
                    new InteractionItem("Холодильник", 1, 50, 180, 450, new List<Interaction> {        // 3.2 Холодильник
                        new Interaction("1. Посмотреть на пустые полки", new List<Impact> {
                            new Impact(Characteristic.time, 90)
                        })
                    }),
                    new InteractionItem("Раковина", 340, 225, 400, 240, new List<Interaction> {        // 3.3 Раковина
                        new Interaction("1. Вымыть руки", new List<Impact> {
                            new Impact(Characteristic.time, 90),
                            new Impact(Characteristic.hygiene, -10)
                        })
                    }),
                    new InteractionItem("Телевизор", 450, 85, 520, 140, new List<Interaction> {        // 3.4 Телевизор
                        new Interaction("1. Посмотреть мелодраму", new List<Impact> {
                            new Impact(Characteristic.time, 90),
                            new Impact(Characteristic.satiety, -10),
                            new Impact(Characteristic.cheerfulness, -15),
                            new Impact(Characteristic.hygiene, -10),
                            new Impact(Characteristic.intelligence, 7),
                            new Impact(Characteristic.mood, -20)
                        }),
                        new Interaction("2. Посмотреть Discovery", new List<Impact> {
                            new Impact(Characteristic.time, 90),
                            new Impact(Characteristic.satiety, -10),
                            new Impact(Characteristic.cheerfulness, -15),
                            new Impact(Characteristic.hygiene, -10),
                            new Impact(Characteristic.intelligence, 7),
                            new Impact(Characteristic.mood, -20)
                        }),
                        new Interaction("3. Посмотреть рекламу", new List<Impact> {
                            new Impact(Characteristic.time, 90),
                            new Impact(Characteristic.satiety, -10),
                            new Impact(Characteristic.cheerfulness, -15),
                            new Impact(Characteristic.hygiene, -10),
                            new Impact(Characteristic.intelligence, 7),
                            new Impact(Characteristic.mood, -20)
                        })
                    }),
                }),
                new GameLocation("Ванная", "..\\..\\Images\\bathroom.png", new List<InteractionItem> {  // 4 Ванная
                    new InteractionItem("Коридор",325,394,373,444, new List<Interaction> {            // 4.1 Выход
                        new Interaction("1. Пойти в спальню", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.bedroom)),
                            new Impact(Characteristic.time, 5)
                        }),
                        new Interaction("2. Пойти на кухню", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.kitchen)),
                            new Impact(Characteristic.time, 5)
                        }),
                        new Interaction("3. Выйти на улицу", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.map)),
                            new Impact(Characteristic.time, 5)
                        })
                    })
                }),
                new GameLocation("Работа", "..\\..\\Images\\work.png", new List<InteractionItem> {      // 5 Работа
                    new InteractionItem("Выход", 381,388,434,436, new List<Interaction> {            // 5.1 Выход
                        new Interaction("1. Пойти на улицу", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.map)),
                            new Impact(Characteristic.time, 5)
                        })
                    }),
                    new InteractionItem("Компьютер", 155, 105, 265, 280, new List<Interaction> {        // 5.2 Компьютер
                        new Interaction("1. Поработать", new List<Impact> {
                            new Impact(Characteristic.cheerfulness, -10),
                            new Impact(Characteristic.time, 5)
                        }),
                        new Interaction("2. Поиграть в \"косынку\"", new List<Impact> {
                            new Impact(Characteristic.mood, 10),
                            new Impact(Characteristic.time, 10)
                        })
                    }),
                    new InteractionItem("Кресло", 500, 330, 710, 455, new List<Interaction> {            // 5.3 Кресло
                        new Interaction("1. Расслабиться", new List<Impact> {
                            new Impact(Characteristic.cheerfulness, 5),
                            new Impact(Characteristic.time, 5)
                        }),
                        new Interaction("2. Вздремнуть", new List<Impact> {
                            new Impact(Characteristic.cheerfulness, 10),
                            new Impact(Characteristic.time, 10)
                        })
                    }),
                    new InteractionItem("Цветок Василий", 530, 75, 600, 315, new List<Interaction> {    // 5.4 Цветок
                        new Interaction("1. Поговорить по душам", new List<Impact> {
                            new Impact(Characteristic.mood, 5),
                            new Impact(Characteristic.time, 5)
                        }),
                        new Interaction("2. Полить", new List<Impact> {
                            new Impact(Characteristic.mood, 3),
                            new Impact(Characteristic.time, 10)
                        })
                    })
                }),
                new GameLocation("Магазин", "..\\..\\Images\\shop.png", new List<InteractionItem> {      // 6 Магазин
                    new InteractionItem("Выход", 303,403,356,453, new List<Interaction> {            // 6.1 Выход
                        new Interaction("1. Пойти на улицу", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.map)),
                            new Impact(Characteristic.time, 5)
                        })
                    })
                }),
                new GameLocation("Улица", "..\\..\\Images\\map.png", new List<InteractionItem> {       // 7 Карта
                    new InteractionItem("Парк", 105, 230, 185, 305, new List<Interaction> {            // 7.1 Парк
                        new Interaction("1. Пойти в парк", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.park)),
                            new Impact(Characteristic.time, 5)
                        })
                    }),
                    new InteractionItem("Магазин", 225, 60, 300, 130, new List<Interaction> {            // 7.2 Магазин
                        new Interaction("1. Пойти в магазин", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.shop)),
                            new Impact(Characteristic.time, 5)
                        })
                    }),
                    new InteractionItem("Академия", 465, 85, 535, 155, new List<Interaction> {            // 7.3 Академия
                        new Interaction("1. Пойти в академию", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.academy)),
                            new Impact(Characteristic.time, 5)
                        })
                    }),
                    new InteractionItem("Дом", 405, 270, 480, 340, new List<Interaction> {              // 7.4 Дом
                        new Interaction("1. Пойти домой", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.bedroom)),
                            new Impact(Characteristic.time, 5)
                        })
                    }),
                    new InteractionItem("Работа", 685, 255, 760, 330, new List<Interaction> {            // 7.5 Работа
                        new Interaction("1. Пойти на работу", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.work)),
                            new Impact(Characteristic.time, 5)
                        })
                    })
                }),
                new GameLocation("Улица", "..\\..\\Images\\academy.png", new List<InteractionItem> {       // 8 Учеба
                    new InteractionItem(" ",298,398,349,445, new List<Interaction> {            // 8.1 Выход
                        new Interaction("1. Выход на улицу", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.map)),
                            new Impact(Characteristic.time, 5)
                        })
                    })
                })
            };
        }
    }
}
