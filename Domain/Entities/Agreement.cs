using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Agreement
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public byte[] AgreementFile { get; set; }


    }
}
