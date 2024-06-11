using System.ComponentModel.DataAnnotations;

namespace alpha_bar_service.Models
{
    public class Product_dto
    {
        [Key]
        public int Product_ID { get; set; }

        [MaxLength(100)]
        public string Product_Name { get; set; }

        [MaxLength(100)]
        public string Drink_Name { get; set; }
    }
}
