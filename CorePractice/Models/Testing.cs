using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePractice.Models
{
    public class Testing
    {
        public Testing()
        {
            ClassEntryDetails = new List<ClassEntryDetails>();
        }
        public List<ClassEntryDetails> ClassEntryDetails { get; set; }
    }

    public class ClassEntryDetails
    {
        public virtual string Name { get; set; }
        public virtual int Quantity { get; set; }
        public virtual decimal Amount { get; set; }
        public virtual decimal Duration { get; set; }
    }
}
