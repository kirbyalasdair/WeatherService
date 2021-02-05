using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IAPI.Domain.Models
{
    public class MetArea
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public List<int> Crags { get; set; }


    }
}
