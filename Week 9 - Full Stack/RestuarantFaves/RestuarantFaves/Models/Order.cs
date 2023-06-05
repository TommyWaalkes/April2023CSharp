using System.ComponentModel.DataAnnotations;

namespace RestuarantFaves.Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }

        [MaxLength(80)]
        public string Description { get; set; }

        [MaxLength(30)]
        public string Restaurant { get; set; }

        [Range(1,5)]
        public int Rating { get; set; }

        public bool OrderAgain { get; set; }
    }
}
