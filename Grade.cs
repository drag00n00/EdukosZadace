namespace EdukosSchool
{
    class Grade
    {
        private string name;
        private List<Student> students;

        public string GetName
        { get { return name; } }

        private string SetName
        { set { name = value; } }

        public List<Student> GetStudents
        { get { return students; } }

        private List<Student> SetStudents
        { set { students = value; } }

        public Grade(string Name)
        {
            name = Name;
            students = new List<Student>();
        }

        public void AddStudent(string name, string lastName, string Id)
        {
            students.Add(new Student(name, lastName, Id));
        }

        public void RemoveStudent(string id)
        {
            foreach (Student student in students)
            {
                if (student.GetId == id) { students.Remove(student); }
            }
        }

        public void GradeReview ()
        {
            foreach (Student student in students)
            { Console.WriteLine(student.GetId + student.GetName + student.GetLastName + student.GetGrades); }
        }
    }
}
