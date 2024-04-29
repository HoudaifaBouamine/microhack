using AutoMapper;
using OptiField.Domain;

namespace OptiField;

public class OptiFieldApplicationAutoMapperProfile : Profile
{
    public OptiFieldApplicationAutoMapperProfile()
    {
        // mapping project to projcet dto
        CreateMap<Project, ProjectDto>();
    }
}
