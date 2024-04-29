using System.Threading.Tasks;
using Microsoft.Extensions.Primitives;

namespace OptiField;

public interface IProjectService
{
    Task<GetProjecsListResponse> GetProjectsAsync(string? SearchPattern, int PageNumber = 1, int PageSize = 10);

}
