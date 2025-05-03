namespace CQRS_4.Model.DTOs
{
    public class UpdateEmployeeDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public required string Email { get; set; }
        public required string Phone { get; set; }
        public long Salary { get; set; }
    }
}
