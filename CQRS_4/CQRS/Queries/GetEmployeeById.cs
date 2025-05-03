using CQRS_4.Model.DTOs;
using CQRS_4.Model.Entity;
using MediatR;

namespace CQRS_4.CQRS.Queries
{
    public class GetEmployeeById:IRequest<Employees>
    {
        public GetEmployeeByIdDTO GetEmployeeByIdDTO { get; }

        public GetEmployeeById(GetEmployeeByIdDTO dto)
        {
            GetEmployeeByIdDTO = dto;

        }
    }
}
