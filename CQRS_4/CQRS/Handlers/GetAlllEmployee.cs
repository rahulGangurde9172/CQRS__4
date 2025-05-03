using CQRS_4.CQRS.Queries;
using CQRS_4.Model.Entity;
using CQRS_4.Repository.Interface;
using MediatR;

namespace CQRS_4.CQRS.Handlers
{
    public class GetAlllEmployee : IRequestHandler<GetAllEmployeeQuery,IEnumerable<Employees>>
    {

        public readonly IEmployeeRepository _EmployeeRepository;
        public GetAlllEmployee(IEmployeeRepository employeeRepository)
        { 
            _EmployeeRepository = employeeRepository;
        }

        
        public async Task<IEnumerable<Employees>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            return await _EmployeeRepository.GetAllEmployee();
             
        }
    }
}
