using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.Projects.Queries.GetProjectDetails
{
    public class GetProjectDetailsQuery : IRequest<Project>
    {
        public int Id { get; set; }
    }
}
