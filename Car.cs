using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitProject
{
    public class Car
    {
        public string Model { get; set; }

        public string Title { get; set; }

        public Car(string model, string title)
        {
            this.Model = model;
            this.Title = title;
        }
    }
}
