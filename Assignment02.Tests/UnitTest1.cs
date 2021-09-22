using System;
using Xunit;

namespace Assignment2.tests
{
    public class UnitTest1
    {
        // Related to Student Class
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

        // Related to Student Record
        [Fact]
        public void StudentRec_ToString_FeaturingBobJones() {
            var student = new ImmutableStudent(0, "Bob", "Jones", new DateTime(2000, 01, 01), new DateTime(2005, 01, 01), new DateTime(2010, 01, 01));
            string expected = "Bob Jones, id: 0, status: Dropout, StartDate: 2000/01/01, EndDate: 2005/01/01, GraduationDate: 2010/01/01";
            Assert.Equal(expected, student.ToString());
        }

        [Fact]
        public void StudentRec_Status_Given02_05_1999_ReturnsGraduated() {
            var student = new ImmutableStudent(0, "Bob", "Jones", new DateTime(1995, 01, 01), new DateTime(1998, 12, 31), new DateTime(1999, 01, 01));
            var expected = Status.Graduated;
            Assert.Equal(expected, student.Status);
        }

        [Fact]
        public void StudentRec_Status_Given02_05_2019_ReturnsActive() {
            var student = new ImmutableStudent(0, "Bob", "Jones", new DateTime(2019, 01, 01), new DateTime(2022, 12, 31), default);
            var expected = Status.Active;
            Assert.Equal(expected, student.Status);
        }

        [Fact]
        public void StudentRec_Status_Given02_05_2021ReturnsNew() {
            var student = new ImmutableStudent(0, "Bob", "Jones", new DateTime(2022, 01, 01), new DateTime(2025, 12, 31), default);
            var expected = Status.New;
            Assert.Equal(expected, student.Status);
        }

        [Fact]
        public void StudentRec_Status_GivenDefault_ReturnsDropOut() {
            var student = new ImmutableStudent(0, "Bob", "Jones", new DateTime(1995, 01, 01), new DateTime(1998, 12, 31), default);
            var expected = Status.Dropout;
            Assert.Equal(expected, student.Status);
        }

        [Fact]
        public void StudentRec_Equals_GivenBobJones_ReturnsTrue() {
            var student = new ImmutableStudent(0, "Bob", "Jones", new DateTime(2000, 01, 01), new DateTime(2005, 01, 01), new DateTime(2010, 01, 01));
            var imposter = new ImmutableStudent(0, "Bob", "Jones", new DateTime(2000, 01, 01), new DateTime(2005, 01, 01), new DateTime(2010, 01, 01));

            Assert.True(student.Equals(imposter));

        }

        [Fact]
        public void StudentRec_Equals_GivenJobBones_ReturnsFalse() {
            var student = new ImmutableStudent(0, "Bob", "Jones", new DateTime(2000, 01, 01), new DateTime(2005, 01, 01), new DateTime(2010, 01, 01));
            var imposter = new ImmutableStudent(0, "Job", "Bones", new DateTime(2000, 01, 01), new DateTime(2005, 01, 01), new DateTime(2010, 01, 01));

            Assert.False(student.Equals(imposter));
        }
    }
}