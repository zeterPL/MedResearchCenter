using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.PatientProjects.Queries.GetPatientProjectsByPatientId
{
    public class GetPatientProjectsByPatientIdQuery : IRequest<List<PatientProject>>
    {
        public int PatientId { get; set; }
    }
}
