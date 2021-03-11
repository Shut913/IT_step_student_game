using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bojko_Tarasenko_exam.Classes
{
    [Serializable()]
    public class Work
    {
        static private List<DayOfWeek> _workDays = new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday };
        static private List<string> WorkPositions = new List<string> { "Нет", "Стажер", "Трейни", "Джун", "Мидл", "Сеньор" };
        static private List<int> salaries = new List<int> { 0, 250, 300, 350, 700, 1500 };

        public int positionId;                             // Id должности
        public string WorkPosition { get; private set; }    // Должность
        public int Salary { get; private set; }             // Зарплата
        public Work()
        {
            positionId = 0;
            WorkPosition = WorkPositions[positionId];
            Salary = salaries[positionId];
        }

        static public bool IsWorkDay(DayOfWeek day)
        {
            if (_workDays.Contains(day))
                return true;
            return false;
        }
        static public bool IsWorkTime(DateTime time)
        {
            if (time.Hour >= 6 && time.Hour <= 8)
                return true;
            else return false;
        }
        public bool HasJob()
        {
            if (positionId == 0) return false;
            else return true;
        }
        public void Promote()
        {
            if (positionId < WorkPositions.Count-1) ++positionId;
            WorkPosition = WorkPositions[positionId];
            Salary = salaries[positionId];
        }
        public void Demote()
        {
            if (positionId > 0) --positionId;
            WorkPosition = WorkPositions[positionId];
            Salary = salaries[positionId];
        }
    }
}
