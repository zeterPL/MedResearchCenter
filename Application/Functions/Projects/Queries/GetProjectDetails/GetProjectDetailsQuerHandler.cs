using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.Projects.Queries.GetProjectDetails
{
    public class GetProjectDetailsQuerHandler : IRequestHandler<GetProjectDetailsQuery, Project>
    {
        private readonly IAsyncRepository<Project> _projectRepository;

        public GetProjectDetailsQuerHandler(IAsyncRepository<Project> projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<Project> Handle(GetProjectDetailsQuery request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.GetByIdAsync(request.Id);

            return project;
        }
    }
}
