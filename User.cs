namespace TestGitProject
{
    public class User
    {
        public string Age { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public User(string name, string age, string lastName)
        {
            this.Age = age;
            this.Name = name;
            this.LastName = lastName;
        }

        public void PrintUserName()
        {
            System.Console.WriteLine("User name: " + this.Name + " " + this.LastName + "!");
        }    
    }
}
