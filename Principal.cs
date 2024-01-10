namespace EdukosSchool
{
    class Principal : Person
    {
        private List<Student> students;
        private List<Teacher> teachers;

        public Principal(string Name, string LastName, string Id)
            : base(Name, LastName, Id) { }

        public void AddStudent(Grade grade,string name, string lastName, string id)
        {
            new Student(name, lastName, id, grade);
        }

        public void AddTeacher(string name, string lastName, string id)
        {
            new Teacher(name, lastName, id);
        }

        public void RemoveStudent(string id)
        {            
            foreach (Student student in students)
            {
                if (student.GetId == id) { students.Remove(student); }
            }
        }

        public void RemoveTeacher(string id)
        {
            foreach (Teacher teacher in teachers)
            {
                if (teacher.GetId == id) { teachers.Remove(teacher); }
            }
        }

        public void ShowSchoolGrades()
        {
            foreach(Student student in students)
            {
                Console.WriteLine($"{student.GetId} {student.GetName} {student.GetLastName} ");
                student.GradeReview();
            }
        }
    }
}
