using CQRS_4.CQRS.Commands;
using CQRS_4.Model.Entity;
using CQRS_4.Repository.Interface;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_4.CQRS.Handlers
{
    public class CreateCommandHandler : IRequestHandler<CreateCommand, int>
    {
        private readonly IEmployeeRepository _repository;

        public CreateCommandHandler(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(CreateCommand request, CancellationToken cancellationToken)
        {
          

            var employee = new Employees
            {
                Name = request.CreateEmployeeDTO.Name,
                Email = request.CreateEmployeeDTO.Email,
                Phone = request.CreateEmployeeDTO.Phone,
                Salary = request.CreateEmployeeDTO.Salary,
            };
            
            var employeeID =  await _repository.AddEmployeeAsync(employee);
            return employeeID.Id;
        }
    }
}
