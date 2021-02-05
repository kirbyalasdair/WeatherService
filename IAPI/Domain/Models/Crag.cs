using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IAPI.Domain.Models
{
    public class Crag
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public List<EDirection> Directions { get; set; }
        public ERockType RockType { get; set; }
        public int DryFor { get; set; }
        public int Rating { get; set; }
        //Extent for Winter


    }
}
