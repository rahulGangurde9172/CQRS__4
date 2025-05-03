namespace CQRS_4.Model.DTOs
{
    public class DeleteEmployeeDTO
    {
        public int Id { get; set; }

        public DeleteEmployeeDTO(int id)
        {
            Id = id;
        }


    }
}
