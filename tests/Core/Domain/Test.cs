using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests.Core.Domain
{
    class Test
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Subject { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual IList<Question> Questions { get; set; }

        public Test()
        {
            Questions = new List<Question>();
        }

    }
}
