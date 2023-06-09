using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Classes
{
    public class Sportsman
    {
        public int Id { get;}
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime BirthDate { get; set; } = DateTime.Now;
        public Sportsman() 
        { 
            SportsmenCount++;
            Id = SportsmenCount;
        }
        private static int SportsmenCount = 0;
    }
}
