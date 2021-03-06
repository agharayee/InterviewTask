using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Data.Entities
{
    public class PersonalDetails
    {
        public int Id { get; set; }
        public string CVFileName { get; set; }
        public string CVFileType { get; set; }
        public byte[] CVFiles { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual ApplicationUser users { get; set; }
    }
}
