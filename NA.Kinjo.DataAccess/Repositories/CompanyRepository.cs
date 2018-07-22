using Dapper;
using NA.Kinjo.DataAccess.Interfaces;
using NA.Kinjo.Entities;
using NA.Kinjo.Entities.ViewModel;
using System.Data;
using System.Threading.Tasks;

namespace NA.Kinjo.DataAccess.Repositories
{
    public class CompanyRepository: ICompanyRepository
    {
        private readonly IBaseRepository _base;

        public CompanyRepository(IBaseRepository baseRepo)
        {
            _base = baseRepo;
        }

        public async Task<int> CreateCompany(AddCompany company)
        {
            using (var connection = _base.GetConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Email", company.Email);
                parameters.Add("@Password", company.Password);

                parameters.Add("@Name", company.Name);                
                parameters.Add("@Address", company.Address);
                parameters.Add("@Phone", company.Phone);

                var appUserId = await connection.ExecuteAsync("CreateCompany", parameters, null, null, CommandType.StoredProcedure);

                return appUserId;
            }
        }

        public async Task<Company> GetCompanyByEmail(string companyEmail)
        {
            using (var connection = _base.GetConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Email", companyEmail);
                
                var appUserId = await connection.QueryFirstOrDefaultAsync<Company>("GetCompanyByEmail", parameters,null,null,CommandType.StoredProcedure);

                return appUserId;
            }
        }

        public async Task<int> UpdateCompany(Company company)
        {
            using (var connection = _base.GetConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", company.Id);
                parameters.Add("@Email", company.Email);
                parameters.Add("@Name", company.Name);
                parameters.Add("@Address", company.Address);
                parameters.Add("@Phone", company.Phone);

                var rowsAfected = await connection.ExecuteAsync("UpdateCompany", parameters, null, null, CommandType.StoredProcedure);

                return rowsAfected;
            }
        }
    }
}
