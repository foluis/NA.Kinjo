using NA.Kinjo.Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NA.Kinjo.DataAccess.Interfaces
{
    public interface ICompanyRepository
    {
        Task<int> CreateCompany(AddCompany company);
    }
}
