namespace TestGitProject
{
    public class User
    {
        public string Age { get; set; }

        public string Name { get; set; }

        public User(string name, string age)
        {
            this.Age = age;
            this.Name = name;
        }
    }
}
