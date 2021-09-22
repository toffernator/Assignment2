// Old Program.cs file
using System;

namespace Assignment2
{
    public enum Status{
        New, Active, Dropout, Graduated
    }
    public class Student
    {
        readonly int id;
        string GivenName, Surname;
        readonly Status Status;
        DateTime StartDate, EndDate, GraduationDate;
        public Student(int id, string GivenName, string Surname, DateTime StartDate, DateTime EndDate, DateTime GraduationDate){
            this.id = id;
            this.GivenName = GivenName;
            this.Surname = Surname;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.GraduationDate = GraduationDate;
            this.Status = StatusFromTime();
            Console.WriteLine(StartDate.ToString("yyyy/mm/dd") +" "+ EndDate.ToString() +" "+ GraduationDate.ToString());
        }
        Status StatusFromTime(){
            if(GraduationDate != default){
                return Status.Graduated;
            }
            if(DateTime.Compare(DateTime.Now, EndDate)>0){
                return Status.Dropout;
            }
            if(DateTime.Compare(DateTime.Now, StartDate)>0){
                return Status.Active;
            }
            return Status.New;
        }
        

        public string ToString(){
            if(Status == Status.Graduated){
              return $"{GivenName} {Surname}, id: {id}, status: {Status}, StartDate: {StartDate.ToString("yyyy/MM/dd")}, EndDate: {EndDate.ToString("yyyy/MM/dd")}, GraduationDate: {GraduationDate.ToString("yyyy/MM/dd")}";
            }
            return $"{GivenName} {Surname}, id: {id}, status: {Status}, StartDate: {StartDate.ToString("yyyy/MM/dd")}, EndDate: {EndDate.ToString("yyyy/MM/dd")}";
        }
        static void Main(string[] args)
        {
            var student = new Student(0, "Bob", "Jones", new DateTime(2000, 05, 01), new DateTime(2005, 03, 01),default);
        }
    }

    public record ImmutableStudent 
    {
        public int id { get; init; }
        public string GivenName{ get; init; }
        public string Surname{ get; init; }
        public Status Status{ get; }
        public DateTime StartDate{ get; init; }
        public DateTime EndDate{ get; init; }
        public DateTime GraduationDate{ get; init; } = default;

        public ImmutableStudent(int id, string GivenName, string Surname, DateTime StartDate, DateTime EndDate, DateTime GraduationDate)
        {
            this.id = id;
            this.GivenName = GivenName;
            this.Surname = Surname;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.GraduationDate = GraduationDate;

            this.Status = initStatus(); 
        }

        private Status initStatus() 
        {
            if(GraduationDate != default)
            {
                return Status.Graduated;
            }
            if(DateTime.Compare(DateTime.Now, EndDate) > 0)
            {
                return Status.Dropout;
            }
            if(DateTime.Compare(DateTime.Now, StartDate) > 0)
            {
                return Status.Active;
            }
            return Status.New;
        }

        public override string ToString()
        {
            string asString = $"{GivenName} {Surname}, id: {id}, status: {Status}, StartDate: {StartDate.ToString("yyyy/MM/dd")}, EndDate: {EndDate.ToString("yyyy/MM/dd")}";
            if (Status == Status.Graduated) 
            {
                asString += $"GraduationDate: {GraduationDate.ToString("yyyy/MM/dd")}";
            }

            return asString;
        }
    }
}