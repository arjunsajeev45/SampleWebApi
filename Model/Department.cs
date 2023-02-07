using System.ComponentModel.DataAnnotations;

namespace SampleWebApi.Model
{
    public class Department
    {
        [Key]
        public int DId { get; set; }

        public string DName { get; set; }

    }
}
