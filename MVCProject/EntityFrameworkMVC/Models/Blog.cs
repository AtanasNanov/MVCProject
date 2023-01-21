using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkMVC.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string? BlogName { get; set; }
        public string BlogDescription { get; set; }
        public string BlogOwner { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
