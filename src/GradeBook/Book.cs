namespace GradeBook
{
    public class Book
    {        
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public Book(string name, List<double> grades)
        {
            this.grades = grades;
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public List<double> GetGrades()
        {
            return grades;
        }

        public double GetSum()
        {
            return grades.Sum();
        }

        public double GetAverage()
        {
            return grades.Average();
        }

        public double GetMin()
        {
            return grades.Min();
        }

        public double GetMax()
        {
            return grades.Max();
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = GetAverage();
            result.High = GetMax();
            result.Low = GetMin();
            return result;
        }        

        private List<double> grades;
        private string name;
    }
}