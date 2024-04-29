using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using OptiField.Domain;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace OptiField;

public class ProjectService(IRepository<Project> repository) : ApplicationService, IProjectService
{
    private readonly IRepository<Project> repo = repository;



    public async Task<GetProjecsListResponse> GetProjectsAsync(string? SearchPattern, int PageNumber = 1, int PageSize = 10)
    {        
        var projects = await repo.GetPagedListAsync((PageNumber - 1) * PageSize, PageSize,"Id ASC");

        return new GetProjecsListResponse
        (
            TotalCount: projects.Count(),
            PageNumber: PageNumber,
            PageSize: PageSize,
            HasPreviousPage : PageNumber > 1,
            HasNextPage: projects.Count() > PageNumber * PageSize,
            Projects : projects.Select(ObjectMapper.Map<Project,ProjectDto>).ToList()
        );
    }

}
