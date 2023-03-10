using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMasterDetailList
{
    public class Movie
    {
       public string Name { get; set; }
       public string Review { get; set; }
       public int RottenTomatosScore { get; set; }


        public Movie()
        {
            Name = "No Movie Name";
            Review = "No Review";
            RottenTomatosScore = 0;

        }
        public override string ToString()
        {
            return Name;
        }
    }
}
