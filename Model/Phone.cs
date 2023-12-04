

namespace TGDD_Clone_2;
public class Phone{
    public int Id { get; set; }

    public string Model { get; set; }

    public string Brand { get; set; }

    public string ProductLine { get; set; }

    public string Color { get; set; }

    public decimal BasePrice { get; set; }

    public string Description { get; set; }

    public string ImageUrl { get; set; }
    private decimal _discount = 1;
    public decimal Discount
    {
        get { return _discount; }
        set { _discount = value; }
    }
    public string Url
    {
    get
    {
      return "Detail/" + this.Id;
    }
    }
    public string ProductImage{get; set;}

    public decimal GetTotalPrice()
    {
        return this.BasePrice + this.BasePrice*this.Discount;
    }
    public string GetFormattedBasePrice() => GetTotalPrice().ToString("0.00");
}
