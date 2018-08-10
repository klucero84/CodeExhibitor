using CodeExhibitor.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeExhibitor.Data
{
    public class AlgorithmContext : DbContext
    {
        public AlgorithmContext(DbContextOptions<AlgorithmContext> options) : base(options) { }
        public DbSet<Algorithm> Algorithms { get; set; }
        public DbSet<InterviewQuestion> InterviewQuestions { get; set; }

    }

    

   
}
