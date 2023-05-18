using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pesel { get; set; }
        public string PhoneNumber { get; set; } 

        public ICollection<PatientProject> PatientProjects { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
