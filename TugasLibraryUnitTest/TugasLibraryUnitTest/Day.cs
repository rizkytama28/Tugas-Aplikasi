using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TugasLibraryUnitTest;

namespace TugasLibraryUnitTest
{
    [TestFixture]
    public class Day
    {
        [Test]
        public void NameOfDay(string day)
        {
            int NameOfDay = (int)System.DateTime.Now.DayOfWeek;
            
        }
    }
}
