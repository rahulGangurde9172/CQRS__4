using CQRS_4.CQRS.Queries;
using CQRS_4.Model.Entity;
using CQRS_4.Repository.Interface;
using MediatR;

namespace CQRS_4.CQRS.Handlers
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeById, Employees>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetEmployeeByIdHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employees> Handle(GetEmployeeById request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetEmployeeById(request.GetEmployeeByIdDTO.Id);
            return employee;
        }
    }
}
