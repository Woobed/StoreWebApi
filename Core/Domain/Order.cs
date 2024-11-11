

namespace Domain
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string? Adress { get; set; }
        public string? Created { get; set; }

        public string? Note { get; set; }

        public decimal Price {  get; set; } 

    }
}
