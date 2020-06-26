using BlueSite.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlueSite.Data.Interfaces
{
    public interface IJobHuntRepository
    {
        List<ActionItem> AllActions { get; }
        List<Company> AllCompanies { get; }
        Company GetCompany(int id);
        ActionType[] Types { get; }
    }
}
