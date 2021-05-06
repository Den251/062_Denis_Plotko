using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task1.Classes
{
    public class DayLister : ILister
    {
        public string[] ShowList()
        {
            string[] daysArray = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            return daysArray;
        }
    }
}
