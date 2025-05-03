

using CQRS_4.Model.DTOs;
using CQRS_4.Model.Entity;
using MediatR;

namespace CQRS_4.CQRS.Commands
{
    public class CreateCommand:IRequest<int>
    {
        public CreateEmployeeDTO CreateEmployeeDTO { get; set; }

        public CreateCommand(CreateEmployeeDTO createEmployee)
        {
            this.CreateEmployeeDTO = createEmployee;
        }
    }
}
