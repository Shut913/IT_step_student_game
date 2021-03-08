using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bojko_Tarasenko_exam.Classes
{
    [Serializable()]
    public class Study
    {
        private List<int> _marks;
        static private List<DayOfWeek> _studyDays = new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Wednesday, DayOfWeek.Friday };
        public Study() 
        {
            _marks = new List<int>();
        }
        public void AddMark(float intelligence)
        {
            int mark=0;
            if (intelligence >= 95) mark = 12;
            else if (intelligence >= 90) mark = 11;
            else if (intelligence >= 80) mark = 10;
            else if (intelligence >= 75) mark = 9;
            else if (intelligence >= 65) mark = 8;
            else if (intelligence >= 55) mark = 7;
            else if (intelligence >= 45) mark = 6;
            else if (intelligence >= 35) mark = 5;
            else if (intelligence >= 25) mark = 4;
            else if (intelligence >= 15) mark = 3;
            else if (intelligence >= 0) mark = 2;
            _marks.Add(mark);
        }
        static public bool IsStudyDay(DayOfWeek day)
        {
            if (_studyDays.Contains(day))
                return true;
            return false;
        }
        static public bool IsStudyTime(DateTime time)
        {
            if (time.Hour >= 17 && time.Hour <= 19)
                return true;
            else return false;
        }
        public double GetAverageMark()
        {
            if (_marks.Count > 0)
                return _marks.Average();
            else return 0;
        }
        public int GetLastMark()
        {
            if (_marks.Count > 0)
                return _marks[_marks.Count - 1];
            else return 0;
        }
    }
}
