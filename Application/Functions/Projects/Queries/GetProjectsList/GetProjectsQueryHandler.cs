using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.Projects.Queries.GetProjectsList
{
    public class GetProjectsQueryHandler : IRequestHandler<GetProjectsQuery, List<Project>>
    {
        private readonly IAsyncRepository<Project> _projectRepository;

        public GetProjectsQueryHandler(IAsyncRepository<Project> projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<List<Project>> Handle(GetProjectsQuery request, CancellationToken cancellationToken)
        {
            var all = await _projectRepository.GetAllAsync();

            return (List<Project>)all;
        }
    }
}
