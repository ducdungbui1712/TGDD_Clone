using System.Text.Json.Serialization;
namespace TGDD_Clone_2;
public class Order
{
    public int OrderId { get; set; }

    public string UserId { get; set; }

    public DateTime CreatedTime { get; set; }

    public Address DeliveryAddress { get; set; } = new Address();

    public List<Phone> Phones { get; set; } = new List<Phone>();

    public decimal GetTotalPrice() => Phones.Sum(p => p.GetTotalPrice());

    public string GetFormattedTotalPrice() => GetTotalPrice().ToString("0.00");
}