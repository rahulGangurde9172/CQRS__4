using CQRS_4.Model.Entity;
using MediatR;

namespace CQRS_4.CQRS.Queries
{
    public class GetAllEmployeeQuery:IRequest<IEnumerable<Employees>>
    {
    }
}
