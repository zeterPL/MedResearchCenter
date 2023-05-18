using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.PatientProjects.Queries.GetPatientProjectsByPatientId
{
    public class GetPatientProjectsByPatientIdQueryHandler : IRequestHandler<GetPatientProjectsByPatientIdQuery, List<PatientProject>>
    {
        private readonly IAsyncRepository<PatientProject> _patientprojectRepository;

        public GetPatientProjectsByPatientIdQueryHandler(IAsyncRepository<PatientProject> patientprojectRepository)
        {
            _patientprojectRepository = patientprojectRepository;
        }

        public async Task<List<PatientProject>> Handle(GetPatientProjectsByPatientIdQuery request, CancellationToken cancellationToken)
        {
            var all = await _patientprojectRepository.GetAllAsync();
            var ppBypatientIdList = all.Where(pp => pp.PatientId == request.PatientId).ToList();

            return ppBypatientIdList;
        }
    }
}
