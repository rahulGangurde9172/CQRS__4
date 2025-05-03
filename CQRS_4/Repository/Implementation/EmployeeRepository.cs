using CQRS_4.Data;
using CQRS_4.Model.DTOs;
using CQRS_4.Model.Entity;
using CQRS_4.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace CQRS_4.Repository.Implementation
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public readonly EmployeeContext _context;

        public EmployeeRepository(EmployeeContext context)
        {
            _context = context;    
        }

        public async Task<IEnumerable<Employees>> GetAllEmployee()
        {
            var employee = await _context.Employees.ToListAsync();
            return employee;

        }

        public async Task<Employees> GetEmployeeById(int id)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);
            return employee;

        }

        public async Task<Employees> AddEmployeeAsync(Employees employees)
        {
           _context.Employees.Add(employees);
            await _context.SaveChangesAsync();
            return employees;
        }

        public async Task DeleteEmployee(Employees employee)
        {
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();

        }

       
        public async Task<Employees> UpdateEmployee(Employees employees)
        {
            var employee = await _context.Employees.FindAsync(employees.Id);
            employee.Name = employees.Name;
            employee.Email = employees.Email;
            employee.Phone = employees.Phone;
            employee.Salary = employees.Salary;

            await _context.SaveChangesAsync();
            return employees;

            

        }
    }
}
