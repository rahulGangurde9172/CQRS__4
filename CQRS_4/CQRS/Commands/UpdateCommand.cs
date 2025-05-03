using CQRS_4.Model.DTOs;
using MediatR;

namespace CQRS_4.CQRS.Commands
{
    public class UpdateCommand:IRequest<bool>
    {
        public UpdateEmployeeDTO UpdateEmployeeDTO { get; set; }

        public UpdateCommand(UpdateEmployeeDTO updateEmployeeDTO)
        {
            
            this.UpdateEmployeeDTO = updateEmployeeDTO;
        }
    }
}
