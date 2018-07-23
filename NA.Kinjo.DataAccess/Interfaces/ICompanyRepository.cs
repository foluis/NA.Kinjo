using NA.Kinjo.Entities;
using System.Threading.Tasks;

namespace NA.Kinjo.DataAccess.Interfaces
{
    public interface ICompanyRepository
    {
        Task<int> CreateCompany(Company company);
        Task<Company> GetCompanyByEmail(string companyEmail);
        Task<int> UpdateCompany(Company company);
        Task<int> DeleteCompany(int id);
    }
}
