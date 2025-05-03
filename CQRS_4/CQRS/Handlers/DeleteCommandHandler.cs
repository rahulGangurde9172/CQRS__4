using CQRS_4.CQRS.Commands;
using CQRS_4.Repository.Interface;
using MediatR;

namespace CQRS_4.CQRS.Handlers
{
    public class DeleteCommandHandler : IRequestHandler<DeleteCommand, bool>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public DeleteCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<bool> Handle(DeleteCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetEmployeeById(request.DeleteEmployeeDTO.Id);
            if (employee == null)
                return false;

            await _employeeRepository.DeleteEmployee(employee);
            return true;
        }
    }
}
