using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task1.Classes
{
    public class MonthLister:ILister
    {
        public string[] ShowList()
        {
            string[] monthssArray = new string[] { "January", "February", "March", "April", "May", "June", "July", "August",
                "September", "October", "November", "December" };
            return monthssArray;
        }
    }
}
