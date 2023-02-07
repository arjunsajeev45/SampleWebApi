using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleWebApi.Model
{
    public class Employee
    {
        [Key]


        public int Id { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

      
        public int DId { get; set; }
        [ForeignKey("DId")]
        public virtual Department departments { get; set; }
    }
}
