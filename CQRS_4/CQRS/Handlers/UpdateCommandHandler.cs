using CQRS_4.CQRS.Commands;
using CQRS_4.Model.Entity;
using CQRS_4.Repository.Interface;
using MediatR;

namespace CQRS_4.CQRS.Handlers
{
    public class UpdateCommandHandle : IRequestHandler<UpdateCommand, bool>
    {

        public readonly IEmployeeRepository _repository;
        public UpdateCommandHandle(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> Handle(UpdateCommand request, CancellationToken cancellationToken)
        {
            var employee = new Employees
            {
                Id = request.UpdateEmployeeDTO.Id,
                Name = request.UpdateEmployeeDTO.Name,
                Email = request.UpdateEmployeeDTO.Email,
                Phone = request.UpdateEmployeeDTO.Phone,
                Salary = request.UpdateEmployeeDTO.Salary,
            };
            var updatedEmployee = await _repository.UpdateEmployee(employee);

            return updatedEmployee != null;
        }
    }
    
}
