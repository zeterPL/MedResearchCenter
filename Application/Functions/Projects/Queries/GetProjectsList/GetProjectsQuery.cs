using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.Projects.Queries.GetProjectsList
{
    public class GetProjectsQuery : IRequest<List<Project>>
    {
    }
}
