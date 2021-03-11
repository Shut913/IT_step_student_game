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
                        new Interaction("2. Распугать   (В: 10 мин, Г: -2, И: -2, Н: +5)", new List<Impact> {
                            new Impact(Characteristic.hygiene, -2),
                            new Impact(Characteristic.time, 10),
                            new Impact(Characteristic.mood, 5),
                            new Impact(Characteristic.intelligence, -2)
                        })
                    }),
                    new InteractionItem("Фонтан", 615, 320, 810, 400, new List<Interaction> {       // 1.2 Фонтан
                        new Interaction("1. Попить воды   (В: 5 мин, С: +3, Г: -6, Н: -6)", new List<Impact> {
                            new Impact(Characteristic.hygiene, -6),
                            new Impact(Characteristic.mood, -6),
                            new Impact(Characteristic.time, 5),
                            new Impact(Characteristic.satiety, 3)
                        }),
                        new Interaction("2. Искупаться   (В: 10 мин, Г: +10, И: -3, Н: -8)", new List<Impact> {
                            new Impact(Characteristic.hygiene, 10),
                            new Impact(Characteristic.mood, -8),
                            new Impact(Characteristic.time, 10),
                            new Impact(Characteristic.intelligence, -3)
                        }),
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
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.kitchen))
                        }),
                        new Interaction("2. Пойти в ванную комнату", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.bathroom))
                        }),
                        new Interaction("3. Выйти на улицу   (B: 5 мин)", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.map)),
                            new Impact(Characteristic.time, 5)
                        })
                    }),
                    new InteractionItem("Компьютер", 170, 215, 250, 280, new List<Interaction> {        // 2.2 Компьютер
                        new Interaction("1. Почитать методичку   ( В: 2 ч, Б: -30, И: +8, Н: -20)", new List<Impact> {
                            new Impact(Characteristic.time, 120),
                            new Impact(Characteristic.intelligence, 8),
                            new Impact(Characteristic.mood, -20),
                            new Impact(Characteristic.cheerfulness, -30)
                        }),
                        new Interaction("2. Поиграть в танчики   ( В: 3 ч, Б: -10, И: -3, Н: +60)", new List<Impact> {
                            new Impact(Characteristic.time, 180),
                            new Impact(Characteristic.intelligence, -3),
                            new Impact(Characteristic.mood, 60),
                            new Impact(Characteristic.cheerfulness, -10)
                        }),
                        new Interaction("3. Посмотреть YouTube   ( В: 30 мин, И: -1, Н: +20)", new List<Impact> {
                            new Impact(Characteristic.time, 30),
                            new Impact(Characteristic.intelligence, -1),
                            new Impact(Characteristic.mood, 20)
                        }),
                        new Interaction("4. Грязно поругаться на форуме   ( В: 15 мин, И: -5, Н: +50)", new List<Impact> {
                            new Impact(Characteristic.time, 15),
                            new Impact(Characteristic.intelligence, -5),
                            new Impact(Characteristic.mood, 50)
                        }),
                        new Interaction("5. Устроиться на работу   ( В: 30 мин)", new List<Impact> {
                            new Impact(Characteristic.time, 30),
                            new Impact(Characteristic.getWork, 0)
                        })
                    }),
                    new InteractionItem("Книжная полка", 170, 100, 385, 150, new List<Interaction> {        // 2.3 Полка 1
                        new Interaction("1. Почитать художественную литературу   (В: 1 ч, Б: -15, И: +2, Н: +10)", new List<Impact> {
                            new Impact(Characteristic.time, 60),
                            new Impact(Characteristic.cheerfulness, -15),
                            new Impact(Characteristic.intelligence, 2),
                            new Impact(Characteristic.mood, 10)
                        }),
                        new Interaction("2. Почитать учебную литературу   (В: 1 ч, Б: -15, И: +4, Н: -5)", new List<Impact> {
                            new Impact(Characteristic.time, 60),
                            new Impact(Characteristic.cheerfulness, -15),
                            new Impact(Characteristic.intelligence, 4),
                            new Impact(Characteristic.mood, -5)
                        })
                    }),
                    new InteractionItem("Книжная полка", 390, 185, 610, 240, new List<Interaction> {        // 2.4 Полка 2
                         new Interaction("1. Почитать художественную литературу   (В: 1 ч, Б: -15, И: +2, Н: +10)", new List<Impact> {
                            new Impact(Characteristic.time, 60),
                            new Impact(Characteristic.cheerfulness, -15),
                            new Impact(Characteristic.intelligence, 2),
                            new Impact(Characteristic.mood, 10)
                        }),
                         new Interaction("2. Почитать учебную литературу   (В: 1 ч, Б: -15, И: +4, Н: -5)", new List<Impact> {
                            new Impact(Characteristic.time, 60),
                            new Impact(Characteristic.cheerfulness, -15),
                            new Impact(Characteristic.intelligence, 4),
                            new Impact(Characteristic.mood, -5)
                        })
                    }),
                    new InteractionItem("Кровать", 370, 350, 620, 410, new List<Interaction> {        // 2.5 Кровать
                        new Interaction("1. Выспаться   (В: 8 ч, Б: +100)", new List<Impact> {
                            new Impact(Characteristic.cheerfulness, 100),
                             new Impact(Characteristic.time, 480),
                        }),
                        new Interaction("2. Спать   (В: 6 ч, Б: +70)", new List<Impact> {
                            new Impact(Characteristic.cheerfulness, 70),
                             new Impact(Characteristic.time, 360),
                        }),
                        new Interaction("3. Вздремнуть   (В: 30 мин, Б: +5)", new List<Impact> {
                            new Impact(Characteristic.cheerfulness, 5),
                             new Impact(Characteristic.time, 30),
                        })
                    }),
                    new InteractionItem("Записки", 260, 170, 355, 250, new List<Interaction> {        // 2.6 Записки
                        new Interaction("1. Посмотреть рассписание учебы   ", new List<Impact> {
                            new Impact(Characteristic.schedule, 0)
                        }),
                         new Interaction("2. Посмотреть фотографии   (В: 5 мин, Н: +3)", new List<Impact> {
                            new Impact(Characteristic.time, 5),
                            new Impact(Characteristic.mood, 3)
                        })
                    }),
                    new InteractionItem("Окно", 1, 100, 140, 260, new List<Interaction> {               // 2.7 Окно
                        new Interaction("1. Посмотреть в окно (В: 5 мин, Н: +3)", new List<Impact> {
                            new Impact(Characteristic.time, 5),
                            new Impact(Characteristic.mood, 3)
                        })
                    })
                }),
                new GameLocation("Кухня", "..\\..\\Images\\kitchen.png", new List<InteractionItem> {    // 3 Кухня
                    new InteractionItem("Коридор", 414,394,460,443, new List<Interaction> {            // 3.1 Выход
                        new Interaction("1. Пойти в спальню", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.bedroom))
                        }),
                        new Interaction("2. Пойти в ванную комнату", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.bathroom))
                        }),
                        new Interaction("3. Выйти на улицу   (B: 5 мин)", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.map)),
                            new Impact(Characteristic.time, 5)
                        })
                    }),
                    new InteractionItem("Холодильник", 1, 50, 180, 450, new List<Interaction> {        // 3.2 Холодильник
                    }),
                    new InteractionItem("Раковина", 340, 225, 400, 240, new List<Interaction> {        // 3.3 Раковина
                        new Interaction("1. Вымыть руки", new List<Impact> {
                            new Impact(Characteristic.time, 90),
                            new Impact(Characteristic.hygiene, -10)
                        })
                    }),
                    new InteractionItem("Телевизор", 450, 85, 520, 140, new List<Interaction> {        // 3.4 Телевизор
                        new Interaction("1. Посмотреть мелодраму   (В: 1 ч, И: -3, Н: +10)", new List<Impact> {
                            new Impact(Characteristic.time, 60),
                            new Impact(Characteristic.intelligence, -3),
                            new Impact(Characteristic.mood, 10)
                        }),
                        new Interaction("2. Посмотреть Discovery   (В: 1 ч, И: +3, Н: +10)", new List<Impact> {
                            new Impact(Characteristic.time, 60),
                            new Impact(Characteristic.intelligence, 3),
                            new Impact(Characteristic.mood, +10)
                        }),
                        new Interaction("3. Посмотреть рекламу   (В: 10 мин, Н: -5)", new List<Impact> {
                            new Impact(Characteristic.time, 10),
                            new Impact(Characteristic.mood, -5)
                        })
                    }),
                }),
                new GameLocation("Ванная", "..\\..\\Images\\bathroom.png", new List<InteractionItem> {  // 4 Ванная
                    new InteractionItem("Коридор",325,394,373,444, new List<Interaction> {            // 4.1 Выход
                        new Interaction("1. Пойти в спальню", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.bedroom))
                        }),
                        new Interaction("2. Пойти на кухню", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.kitchen))
                        }),
                        new Interaction("3. Выйти на улицу   (B: 5 мин)", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.map)),
                            new Impact(Characteristic.time, 5)
                        })
                    }),
                    new InteractionItem("Раковина",282,255,375,276,new List<Interaction> {                     // 4.2 Раковина 
                        new Interaction("1. Умыться   (B: 5 мин, Г: +10)",new List<Impact> {
                            new Impact(Characteristic.time, 5),
                            new Impact(Characteristic.hygiene, 10)
                        }),
                        new Interaction("2. Помыть руки   (В: 5 мин, Г: +10)",new List<Impact> {
                            new Impact(Characteristic.time, 5),
                            new Impact(Characteristic.hygiene, 10)
                        }),
                        new Interaction("3. Почистить зубы   (В: 5 мин, Г: +10)",new List<Impact> {
                            new Impact(Characteristic.time, 5),
                            new Impact(Characteristic.hygiene, 10)
                        })
                    }),
                    new InteractionItem("Ванна",0,326,250,455,new List<Interaction> {                       //4.3 Ванна
                        new Interaction("1. Принять ванну   (В: 1 час, Г: +100, Н: +20)",new List<Impact> {
                            new Impact(Characteristic.time, 60),
                            new Impact(Characteristic.hygiene, 100),
                            new Impact(Characteristic.mood,20)
                        }),
                        new Interaction("2. Принять душ   (B: 30 мин, Г: +100)",new List<Impact> {
                            new Impact(Characteristic.time, 30),
                            new Impact(Characteristic.hygiene, 100),
                        })
                    }),
                    new InteractionItem("Унитаз",471,387,592,460,new List<Interaction>{                     //4.4 Унитаз 
                        new Interaction("1. Сходить по нужде   (B: 5 мин, Г: -7, Н: +15)",new List<Impact> {
                             new Impact(Characteristic.time, 5),
                             new Impact(Characteristic.hygiene, -7),
                            new Impact(Characteristic.mood, 15)
                        })
                    }),
                    new InteractionItem("Зеркало",267,131,404,233,new List<Interaction> {                   //4.5 Зеркало 
                        new Interaction("1. Посмотреться   (B: 5 мин, H: +5)", new List<Impact> {
                            new Impact(Characteristic.time, 5),
                            new Impact(Characteristic.mood, 5)
                        }),
                        new Interaction("2. Упражняться в риторике  (В: 10 мин, И: +2)", new List<Impact> {
                            new Impact(Characteristic.time, 10),
                            new Impact(Characteristic.intelligence, 2)
                        })
                    })
                }),
                new GameLocation("Работа", "..\\..\\Images\\work.png", new List<InteractionItem> {          // 5 Работа
                    new InteractionItem("Выход", 381,388,434,436, new List<Interaction> {                   // 5.1 Выход
                        new Interaction("1. Пойти на улицу   (B: 5 мин)", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.map)),
                            new Impact(Characteristic.time, 5)
                        })
                    }),
                    new InteractionItem("Компьютер", 155, 105, 265, 280, new List<Interaction> {        // 5.2 Компьютер
                        new Interaction("1. Поработать   (B: 2 ч, Б: -10, И: +3, H: -30)", new List<Impact> {
                            new Impact(Characteristic.cheerfulness, -10),
                            new Impact(Characteristic.time, 120),
                            new Impact(Characteristic.intelligence, 3),
                            new Impact(Characteristic.mood, -30),
                        }),
                        new Interaction("2. Поиграть в \"косынку\"   (B: 10 мин, И: -1, H: +15)", new List<Impact> {
                            new Impact(Characteristic.mood, 15),
                            new Impact(Characteristic.time, 10),
                            new Impact(Characteristic.intelligence, -1)
                        })
                    }),
                    new InteractionItem("Кресло", 500, 330, 710, 455, new List<Interaction> {            // 5.3 Кресло
                        new Interaction("1. Расслабиться   (B: 10 мин, Б: +3)", new List<Impact> {
                            new Impact(Characteristic.cheerfulness, 3),
                            new Impact(Characteristic.time, 10)
                        }),
                        new Interaction("2. Вздремнуть   (B: 30 мин, Б: +10)", new List<Impact> {
                            new Impact(Characteristic.cheerfulness, 10),
                            new Impact(Characteristic.time, 30)
                        })
                    }),
                    new InteractionItem("Цветок Василий", 530, 75, 600, 315, new List<Interaction> {    // 5.4 Цветок
                        new Interaction("1. Поговорить по душам   (B: 10 мин, Н: +5)", new List<Impact> {
                            new Impact(Characteristic.mood, 5),
                            new Impact(Characteristic.time, 10)
                        }),
                        new Interaction("2. Полить   (B: 5 мин, Н: +3)", new List<Impact> {
                            new Impact(Characteristic.mood, 3),
                            new Impact(Characteristic.time, 5)
                        })
                    })
                }),
                new GameLocation("Магазин", "..\\..\\Images\\shop.png", new List<InteractionItem> {     // 6 Магазин
                    new InteractionItem("Выход", 303,403,356,453, new List<Interaction> {               // 6.1 Выход
                        new Interaction("1. Пойти на улицу   (B: 5 мин)", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.map)),
                            new Impact(Characteristic.time, 5)
                        })
                    }),
                    new InteractionItem("Полки", 255,5,735,165, new List<Interaction> {                 // 6.2 Полки
                        new Interaction("1. Купить сок   (Д: -"+ Products.price[(int)Food.juice] +" грн)", new List<Impact> {
                            new Impact(Characteristic.buyFood, (int)Food.juice)
                        }),
                        new Interaction("2. Купить йогурт   (Д: -"+Products.price[(int)Food.yogurt]+" грн)", new List<Impact> {
                            new Impact(Characteristic.buyFood, (int)Food.yogurt)
                        })
                    }),
                    new InteractionItem("Полки", 110,195,230,350, new List<Interaction> {                 // 6.3 Полки
                        new Interaction("1. Купить бананы   (Д: -"+Products.price[(int)Food.banana]+" грн)", new List<Impact> {
                            new Impact(Characteristic.buyFood, (int)Food.banana)
                        }),
                        new Interaction("2. Купить яблоки   (Д: -"+Products.price[(int)Food.apple]+" грн)", new List<Impact> {
                            new Impact(Characteristic.buyFood, (int)Food.apple)
                        })
                    }),
                    new InteractionItem("Полки", 500,200,760,400, new List<Interaction> {                 // 6.4 Полки
                        new Interaction("1. Купить апельсины   (Д: -" + Products.price[(int)Food.orange] + " грн)", new List<Impact> {
                            new Impact(Characteristic.buyFood, (int)Food.orange)
                        }),
                        new Interaction("2. Купить огурцы   (Д: -" + Products.price[(int)Food.cucumber] + " грн)", new List<Impact> {
                            new Impact(Characteristic.buyFood, (int)Food.cucumber)
                        }),
                        new Interaction("3. Купить помидоры   (Д: -" + Products.price[(int)Food.tomato] + " грн)", new List<Impact> {
                            new Impact(Characteristic.buyFood, (int)Food.tomato)
                        }),
                        new Interaction("4. Купить хлеб   (Д: -" + Products.price[(int)Food.bread] + " грн)", new List<Impact> {
                            new Impact(Characteristic.buyFood, (int)Food.bread)
                        })

                    }),
                    new InteractionItem("Холодильник", 1,30,100,425, new List<Interaction> {            // 6.5 Холодильник
                        new Interaction("1. Купить колу   (Д: -" + Products.price[(int)Food.cola] + " грн)", new List<Impact> {
                            new Impact(Characteristic.buyFood, (int)Food.cola)
                        }),
                        new Interaction("2. Купить минералку   (Д: -" + Products.price[(int)Food.water]+" грн)", new List<Impact> {
                            new Impact(Characteristic.buyFood, (int)Food.water)
                        })
                    })
                }),
                new GameLocation("Улица", "..\\..\\Images\\map.png", new List<InteractionItem> {       // 7 Карта
                    new InteractionItem("Парк", 105, 230, 185, 305, new List<Interaction> {            // 7.1 Переход в парк
                        new Interaction("1. Пойти в парк   (B: 5 мин)", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.park)),
                            new Impact(Characteristic.time, 5)
                        })
                    }),
                    new InteractionItem("Магазин", 225, 60, 300, 130, new List<Interaction> {            // 7.2 Переход в магазин
                        new Interaction("1. Пойти в магазин   (B: 5 мин)", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.shop)),
                            new Impact(Characteristic.time, 5)
                        })
                    }),
                    new InteractionItem("Академия", 465, 85, 535, 155, new List<Interaction> {          // 7.3 Переход в академию
                        new Interaction("1. Пойти в академию   (B: 5 мин)", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.academy)),
                            new Impact(Characteristic.time, 5)
                        })
                    }),
                    new InteractionItem("Дом", 405, 270, 480, 340, new List<Interaction> {              // 7.4 Переход в дом
                        new Interaction("1. Пойти домой   (B: 5 мин)", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.bedroom)),
                            new Impact(Characteristic.time, 5)
                        })
                    }),
                    new InteractionItem("Работа", 685, 255, 760, 330, new List<Interaction> {           // 7.5 Переход на работу
                        new Interaction("1. Пойти на работу   (B: 5 мин)", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.work)),
                            new Impact(Characteristic.time, 5)
                        })
                    })
                }),
                new GameLocation("Академия", "..\\..\\Images\\academy.png", new List<InteractionItem> {     // 8 Учеба
                    new InteractionItem(" ",298,398,349,445, new List<Interaction> {                        // 8.1 Выход
                        new Interaction("1. Выход на улицу   (B: 5 мин)", new List<Impact> {
                            new Impact(Characteristic.location, Convert.ToInt32(GLocations.map)),
                            new Impact(Characteristic.time, 5)
                        })
                    }),
                    new InteractionItem("Компьютер",115,230,200,320, new List<Interaction> {                    // 8.2 Компьютер
                        new Interaction("1. Повторять за преподавателем   (B: 30 мин, И: +4)", new List<Impact> {
                            new Impact(Characteristic.intelligence, 2),
                            new Impact(Characteristic.time, 30)
                        }),
                        new Interaction("2. Смотреть в монитор с умным видом   (B: 30 мин, Б: +5, И: -2)", new List<Impact> {
                            new Impact(Characteristic.intelligence, -2),
                            new Impact(Characteristic.time, 5),
                            new Impact(Characteristic.cheerfulness, 5)
                        }),
                        new Interaction("3. Писать свой гениальный код   (B: 30 мин, И: +4)", new List<Impact> {
                            new Impact(Characteristic.intelligence, 2),
                            new Impact(Characteristic.time, 30)
                        }),
                        new Interaction("4. Делать домашнее задание   (B: 20 мин, И: +3)", new List<Impact> {
                            new Impact(Characteristic.intelligence, 1),
                            new Impact(Characteristic.time, 20)
                        })
                    }),
                    new InteractionItem("Преподаватель",295,120,360,220, new List<Interaction> {                // 8.3 Преподаватель
                        new Interaction("1. Задать умный вопрос   (B: 5 мин, И: +3)", new List<Impact> {
                            new Impact(Characteristic.intelligence, 1),
                            new Impact(Characteristic.time, 5)
                        }),
                        new Interaction("2. Поделиться своими наблюдениями   (B: 5 мин, Н: +3)", new List<Impact> {
                            new Impact(Characteristic.time, 5),
                            new Impact(Characteristic.mood, 3)
                        }),
                        new Interaction("3. Внимательно слушать   (B: 20 мин, И: +3)", new List<Impact> {
                            new Impact(Characteristic.time, 20),
                            new Impact(Characteristic.intelligence, 3)
                        }),
                        new Interaction("4. Зарегистрировать в Tinder   (B: 5 мин, И: -5, Н: +10)", new List<Impact> {
                            new Impact(Characteristic.time, 5),
                            new Impact(Characteristic.mood, 10),
                            new Impact(Characteristic.intelligence, -5)
                        })
                    })
                })
            };
        }
    }
}
