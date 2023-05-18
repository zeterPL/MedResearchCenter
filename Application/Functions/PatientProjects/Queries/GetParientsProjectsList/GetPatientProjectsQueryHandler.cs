using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.PatientProjects.Queries.GetParientsProjectsList
{
    public class GetPatientProjectsQueryHandler : IRequestHandler<GetPatientProjectsQuery, List<PatientProject>>
    {
        private readonly IAsyncRepository<PatientProject> _patientprojectRepository;

        public GetPatientProjectsQueryHandler(IAsyncRepository<PatientProject> patientprojectRepository)
        {
            _patientprojectRepository = patientprojectRepository;
        }

        public async Task<List<PatientProject>> Handle(GetPatientProjectsQuery request, CancellationToken cancellationToken)
        {
            var all = await _patientprojectRepository.GetAllAsync();

            return (List<PatientProject>)all;
        }
    }
}
