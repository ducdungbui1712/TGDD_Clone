using System.ComponentModel.DataAnnotations;

namespace CloneTGDD.Web.Models.DTO
{
    public class ProductsDTO
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string Brand { get; set; }

        public string ProductLine { get; set; }

        public string Color { get; set; }

        public decimal BasePrice { get; set; }
        public string ImageUrl { get; set; }
        public string ProductImage { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
    }
}