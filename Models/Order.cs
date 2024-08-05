using System.ComponentModel.DataAnnotations;

namespace CookieWebsite.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string Number { get; set; }
        public string Product{get; set; }
        public DateTime CreatedDate { get; set;}
        public string Address { get; set;}
        public string quantity { get; set;}
      
    }
}
