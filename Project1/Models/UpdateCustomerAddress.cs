namespace Project1.Models
{
    public record UpdateCustomerAddress
    {
        public long CommandId { get; init; }
        public string Name { get; init; }

    }
}
