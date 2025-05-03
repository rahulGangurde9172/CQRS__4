using CQRS_4.Model.Entity;

namespace CQRS_4.Repository.Interface
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employees>> GetAllEmployee();

        Task<Employees> GetEmployeeById(int id);
        Task<Employees> AddEmployeeAsync(Employees employees);

        Task<Employees> UpdateEmployee(Employees employees);

        Task DeleteEmployee(Employees employee);
    }
}
