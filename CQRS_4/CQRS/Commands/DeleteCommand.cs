using CQRS_4.Model.DTOs;
using MediatR;

namespace CQRS_4.CQRS.Commands
{
    public class DeleteCommand:IRequest<bool>
    {
        public DeleteEmployeeDTO DeleteEmployeeDTO { get; set; }

        public DeleteCommand(DeleteEmployeeDTO deleteEmployeeDTO)
        {
            DeleteEmployeeDTO = deleteEmployeeDTO;
        }
    }
}
