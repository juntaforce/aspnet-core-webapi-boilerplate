namespace WebApi.Boilerplate.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
    }
}