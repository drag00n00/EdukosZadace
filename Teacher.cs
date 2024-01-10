namespace EdukosSchool
{
    class Teacher : Person
    {
        private List<string> subjects;
        
        public Teacher(string Name, string LastName, string Id) 
            :base(Name, LastName, Id) { subjects = new List<string>(); }

        public void AddGrade(Grade Grade, int grade, string id)
        {
            List<Student> students = Grade.GetStudents;
            foreach(Student student in students) 
            {
                if (student.GetId == id) { student.GetGrades.Add(grade); }
            }
        }
    }
}
