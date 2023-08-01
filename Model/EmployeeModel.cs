using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Task5.Model
{
    public class EmployeeModel
    {
        public string? Fname { get; set; }
        [Column(TypeName = "char(1)")]
        public string? Minit { get; set; }
        public string? Lname { get; set; }
        [Key]
        [Column(TypeName = "char(9)")]
        public string? ssn { get; set; }
        [DataType(DataType.Date)]
        public DateTime Bdate { get; set; }
        public string? Address { get; set; }
        [Column(TypeName = "char(1)")]
        public string? Sex { get; set; }
        public decimal Salary { get; set; }
        [Column(TypeName = "char(9)")]
        public string? Super_ssn { get; set; }
        public int Dnumber { get; set; }
    }
}
