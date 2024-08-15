using System.ComponentModel.DataAnnotations;

namespace TestWeek7.Models
{
    public class Product
    {
        [Key]
        public int? Id { get; set; }
        public string titel {  get; set; }
        public double price { get; set; }
        public string description { get; set; }
        public string image {  get; set; }
        public string category { get; set; }
    }
}
