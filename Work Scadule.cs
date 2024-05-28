using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class WorkSchedule
    {
        public bool[] days = new bool[7];
        public int Hours { get; set; }
        public WorkSchedule() { }
        public WorkSchedule(bool[] days)
        {
            days = new bool[7];
            Array.Copy(this.days, days, days.Length);
            Hours = workingHours();
        }
        public virtual int workingHours()
        {
            int H = 0;
            for (int i = 0; i < 7; i++)
            {
                if (days[i] == true)
                    Hours += 9;
            }
          return  H ;
        }
    }
}
