using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircus
{
    public class Movies
    {
        public string Name {get; set; }
        public string Description{ get; set; }
        //public MovieCategory Category { get; set; }
        public string Category { get; set; }


        //Constructor

        public Movies(string name, string category)
        {
            this.Name = name;
            this.Category = category;
        }

        //No argument constructor

        public Movies()
        {
            this.Name = "Dumbo";
            this.Category = "Disney";
        }
    }
}
