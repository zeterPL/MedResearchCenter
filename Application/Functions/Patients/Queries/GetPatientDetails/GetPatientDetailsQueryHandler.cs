using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.Patients.Queries.GetPatientDetails
{
    public class GetPatientDetailsQueryHandler : IRequestHandler<GetPatientDetailsQuery, Patient>
    {
        private readonly IAsyncRepository<Patient> _patientRepository;

        public GetPatientDetailsQueryHandler(IAsyncRepository<Patient> patientRepository)
        {
            _patientRepository = patientRepository;
        }


        public async Task<Patient> Handle(GetPatientDetailsQuery request, CancellationToken cancellationToken)
        {
            var patient = await _patientRepository.GetByIdAsync(request.Id);

            return patient;
        }
    }
}
