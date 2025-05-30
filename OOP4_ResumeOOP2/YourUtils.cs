using OOP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_ResumeOOP2
{
    public static class YourUtils
    {
        public static int Tuoi(this Employee emp)
        {
            return DateTime.Now.Year - emp.Birthday.Year;
        }

        public static Boolean CheckBirthday(this Employee chkbirth)
        {
            return DateTime.Now.Month.Equals(chkbirth.Birthday);
        }
    }
}
