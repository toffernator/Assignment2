using System;
using Xunit;

namespace Assignment2.tests
{
    public class UnitTest1
    {
        [Fact]
        public void DateTime_Is_Comparable(){//We wanted to test wether or not datetime was comparable for confirmation
           var a = new DateTime(2000, 01, 01);
           var b = new DateTime(2001, 01, 01);
           Assert.True(DateTime.Compare(a,b)<0);
            
        }
        [Fact]
        public void StudentTostringTest_featuring_Bob_Jones()
        {
            var student = new Student(0, "Bob", "Jones", new DateTime(2000, 01, 01), new DateTime(2005, 01, 01),default);
            string expected = "Bob Jones, id: 0, status: Dropout, StartDate: 2000/01/01, EndDate: 2005/01/01";
            Assert.Equal(expected, student.ToString());
        }

        [Fact]
        public void StudentTostringTest_featuring_Rob_Jones()
        {
            var student = new Student(1, "Rob", "Jones", new DateTime(2000, 01, 01), new DateTime(2010, 05, 05),new DateTime(2010, 05, 05));
            string expected = "Rob Jones, id: 1, status: Graduated, StartDate: 2000/01/01, EndDate: 2010/05/05, GraduationDate: 2010/05/05";
            Assert.Equal(expected, student.ToString());
        }
    }
}