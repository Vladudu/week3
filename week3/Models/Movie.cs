using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week3.Models
{
    public class Movie
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Lenght { get; set; }
    }
}
