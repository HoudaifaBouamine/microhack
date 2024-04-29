

using System;
using Volo.Abp.Domain.Entities;

namespace OptiField.Domain;

public class Project : Entity<Guid>
{
    // public Company ClientCompany {get; private init;} = null!;
    // public Company ProviderCompany { get; private init; } = null!;
    public  Status Status { get; private set; } = Status.Pending;
    public string Content { get; private set; } = string.Empty;
    // public List<Task> Tasks { get; private set; } = [];

    // public Project(Company clientCompany, Company providerCompany, string content)
    // {
    //     Id = Guid.NewGuid();
    //     ClientCompany = clientCompany;
    //     ProviderCompany = providerCompany;
    //     Content = content;
    // }


    public Project(Guid id) : base(id)
    {
        
    }
    protected Project() {}

}

