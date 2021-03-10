using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Data.Entities
{
    public class CertificateUploads
    {
        public int Id { get; set; }
        public string ProfessionalCertFileType { get; set; }
        public byte[] ProfessionalCertFileName { get; set; }
        public string BscCertFileType { get; set; }
        public byte[] BscCertFileName { get; set; }
        public string WaecCertFileType { get; set; }
        public byte[] WaecCertFileName { get; set; }
    }
}
