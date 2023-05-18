using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.Patients.Queries.GetPatientsList
{
    public class GetPatientsQueryHandler : IRequestHandler<GetPatientsQuery, List<Patient>>
    {
        private readonly IAsyncRepository<Patient> _patientRepository;

        public GetPatientsQueryHandler(IAsyncRepository<Patient> patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task<List<Patient>> Handle(GetPatientsQuery request, CancellationToken cancellationToken)
        {
            var all = await _patientRepository.GetAllAsync();

            return (List<Patient>)all;
        }
    }
}
