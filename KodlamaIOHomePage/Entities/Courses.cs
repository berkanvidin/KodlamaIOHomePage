using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOHomePage.Entities
{
    public class Courses : EntityInheritance
    {
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
    }
}
