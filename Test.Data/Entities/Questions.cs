using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Data.Entities
{
    public class Questions
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Results { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
