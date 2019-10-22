namespace TestGitProject
{
    public class Notebook
    {
        public string Title { get; set; }

        public int Ram { get; set; }

        public Notebook(string title2, int ram)
        {
            this.Title = title2;
            this.Ram = ram;
        }
    }
}
