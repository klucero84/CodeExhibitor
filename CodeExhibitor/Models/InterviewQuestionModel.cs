using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeExhibitor.Models
{
    public class InterviewQuestion
    {
        public int InterviewQuestionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string Solution { get; set; }
        public string Objective { get; set; }

    }
}
