namespace TGDD_Clone.Data;
public static class SeedData
{
    public static void Initialize(DBContext context)
    {
        context.Phones.AddRange(
            new Phone
            {
                Id = 1,
                Model = "iPhone 13",
                Brand = "Apple",
                ProductLine = "iPhone",
                Color = "Space Gray",
                BasePrice = 999.99m,
                Description = "The latest iPhone model",
                ImageUrl = ""
            },
            new Phone
            {
                Id = 2,
                Model = "Samsung Galaxy S21",
                Brand = "Samsung",
                ProductLine = "Galaxy",
                Color = "Phantom Black",
                BasePrice = 899.99m,
                Description = "High-end Android phone",
                ImageUrl = ""
            }
        );


        context.Laptops.AddRange(
            new Laptop
            {
                Id = 1,
                Model = "Dell XPS",
                Brand = "Dell",
                ProductLine = "XPS",
                Color = "Silver",
                BasePrice = 1299.99m,
                Description = "Powerful and sleek laptop",
                ImageUrl = ""
            },
            new Laptop
            {
                Id = 2,
                Model = "MacBook Air",
                Brand = "Apple",
                ProductLine = "MacBook",
                Color = "Gold",
                BasePrice = 1199.99m,
                Description = "Lightweight and portable laptop",
                ImageUrl = ""
            }
        );
        context.SaveChanges();
    }
}
