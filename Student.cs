namespace EdukosSchool
{
    class Student : Person
    {
        private List<int> grades;
        private Grade grade;

        public Student(string Name, string LastName, string Id, Grade Grade) 
            : base(Name, LastName, Id) 
        { 
            grades = new List<int>();
            grade = Grade;
        }

        public void AddGrade(int grade) { grades.Add(grade); }
        public void GradeReview ()
        {
            foreach (var grade in grades)
            {
                Console.WriteLine(grade.ToString());
            }
        }

        public List<int> GetGrades
        { get { return grades; } }  
        
        private List<int> SetGrades
        { set { grades = value; } }
    }
}
