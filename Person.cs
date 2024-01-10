namespace EdukosSchool
{
    abstract class Person
    {
        private string name;
        private string lastName;
        private string id;

        public Person (string Name, string LastName, string Id)
        {
            name= Name;
            lastName= LastName;
            id= Id;
        }

        public string GetName
        { get { return name; } }
        
        private string SetName
        { set { name = value; } }

        public string GetLastName
        { get { return lastName; } }

        private string SetLastName
        { set { lastName = value; } }

        public string GetId
        { get { return id; } }

        private string SetId
        { set { id = value; } }
    }
}
