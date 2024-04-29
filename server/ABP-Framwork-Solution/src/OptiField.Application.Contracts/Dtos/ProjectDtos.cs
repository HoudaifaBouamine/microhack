using System;
using System.Collections.Generic;

namespace OptiField;

public record ProjectDto
{
    public Guid Id { get; init; }
    public string Type { get; init; } = string.Empty;
    public string? Content { get; init; }
}

public record GetProjecsListResponse
(
    int TotalCount,
    int PageNumber,
    int PageSize,
    bool HasPreviousPage,
    bool HasNextPage,
    List<ProjectDto> Projects
);