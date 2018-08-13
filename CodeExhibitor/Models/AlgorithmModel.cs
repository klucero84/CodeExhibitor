using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeExhibitor.Models
{
    public class Algorithm
    {
        public int AlgorithmId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string Objective { get; set; }
        public string BigONotation { get; set; }

        //public IEnumerable<SelectListItem> Names { get; set; }

    }
}
