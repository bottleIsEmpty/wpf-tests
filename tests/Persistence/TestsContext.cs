using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tests.Core.Domain;

namespace tests.Persistence
{
    class TestsContext : DbContext
    {
        public TestsContext() 
            : base("name=TestsContext") { }

        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
    }
}
