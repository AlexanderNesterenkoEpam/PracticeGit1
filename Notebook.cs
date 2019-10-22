namespace TestGitProject
{
    public class Notebook
    {
        public string Title { get; set; }

        public int Ram { get; set; }

        public double Price { get; set; }

        public Notebook(string title2, double price, int ram)
        {
            this.Title = title2;
            this.Price = price;
            this.Ram = ram;

        }
    }
}
