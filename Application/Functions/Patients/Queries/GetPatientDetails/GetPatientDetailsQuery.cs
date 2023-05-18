using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.Patients.Queries.GetPatientDetails
{
    public class GetPatientDetailsQuery : IRequest<Patient>
    {
        public int Id { get; set; }
    }
}
