using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Data.Entities
{
    public class PersonalDetails
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactAddress { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string CVFileType { get; set; }
        public byte[] CVFiles { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
