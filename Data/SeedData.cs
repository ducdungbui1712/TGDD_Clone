namespace TGDD_Clone_2.Data;
public static class SeedData
{
    public static void Initialize(DBContext context)
    {
        context.Phones.AddRange(
            new Phone
            {
                Id = 1,
                Model = "iPhone 14",
                Brand = "Apple",
                ProductLine = "iPhone",
                Color = "Space Gray",
                BasePrice = 999.99m,
                Description = "The latest iPhone model",
                ImageUrl = "https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-xanh-1.jpg",
                Discount = 0.3m,
                ProductImage = "https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-den-glr-1.jpg,https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-den-glr-2.jpg,https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-den-glr-3.jpg,https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-den-glr-4.jpg,https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-den-glr-5.jpg,https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-den-glr-11.jpg,https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-den-glr-12.jpg"
            },
            new Phone
            {
                Id = 2,
                Model = "Samsung Galaxy S22",
                Brand = "Samsung",
                ProductLine = "Galaxy",
                Color = "Phantom Black",
                BasePrice = 899.99m,
                Description = "High-end Android phone",
                ImageUrl = "https://cdn.tgdd.vn/Products/Images/42/235838/samsung-galaxy-s22-ultra-1-1.jpg",
                ProductImage= "https://cdn.tgdd.vn/Products/Images/42/235838/Slider/s22-ultra-1020x570.jpg,https://cdn.tgdd.vn/Products/Images/42/235838/Slider/samsung-galaxy-s22-ultra-1020x570.jpg,https://cdn.tgdd.vn/Products/Images/42/235838/Slider/2.ButSpen-1020x570.jpg,https://cdn.tgdd.vn/Products/Images/42/235838/Slider/8.Matthanbongdem-1020x570.jpg"
            },
            new Phone
            {
                Id = 3,
                Model = "iPhone 14",
                Brand = "Apple",
                ProductLine = "iPhone",
                Color = "Space Gray",
                BasePrice = 999.99m,
                Description = "The latest iPhone model",
                ImageUrl = "https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-xanh-1.jpg",
                ProductImage = "https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-den-glr-1.jpg,https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-den-glr-2.jpg,https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-den-glr-3.jpg,https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-den-glr-4.jpg,https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-den-glr-5.jpg,https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-den-glr-11.jpg,https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-den-glr-12.jpg"

            },
            new Phone
            {
                Id = 4,
                Model = "Samsung Galaxy S22",
                Brand = "Samsung",
                ProductLine = "Galaxy",
                Color = "Phantom Black",
                BasePrice = 899.99m,
                Description = "High-end Android phone",
                ImageUrl = "https://cdn.tgdd.vn/Products/Images/42/235838/samsung-galaxy-s22-ultra-1-1.jpg",

                ProductImage= "https://cdn.tgdd.vn/Products/Images/42/235838/Slider/s22-ultra-1020x570.jpg,https://cdn.tgdd.vn/Products/Images/42/235838/Slider/samsung-galaxy-s22-ultra-1020x570.jpg,https://cdn.tgdd.vn/Products/Images/42/235838/Slider/2.ButSpen-1020x570.jpg,https://cdn.tgdd.vn/Products/Images/42/235838/Slider/8.Matthanbongdem-1020x570.jpg"
            },
            new Phone
            {
                Id = 5,
                Model = "iPhone 14",
                Brand = "Apple",
                ProductLine = "iPhone",
                Color = "Space Gray",
                BasePrice = 999.99m,
                Description = "The latest iPhone model",
                ImageUrl = "https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-xanh-1.jpg",
                ProductImage = "https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-den-glr-1.jpg,https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-den-glr-2.jpg,https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-den-glr-3.jpg,https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-den-glr-4.jpg,https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-den-glr-5.jpg,https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-den-glr-11.jpg,https://cdn.tgdd.vn/Products/Images/42/289663/iphone-14-den-glr-12.jpg"

            },
            new Phone
            {
                Id = 6,
                Model = "Samsung Galaxy S22",
                Brand = "Samsung",
                ProductLine = "Galaxy",
                Color = "Phantom Black",
                BasePrice = 899.99m,
                Description = "High-end Android phone",
                ImageUrl = "https://cdn.tgdd.vn/Products/Images/42/235838/samsung-galaxy-s22-ultra-1-1.jpg",
                ProductImage= "https://cdn.tgdd.vn/Products/Images/42/235838/Slider/s22-ultra-1020x570.jpg,https://cdn.tgdd.vn/Products/Images/42/235838/Slider/samsung-galaxy-s22-ultra-1020x570.jpg,https://cdn.tgdd.vn/Products/Images/42/235838/Slider/2.ButSpen-1020x570.jpg,https://cdn.tgdd.vn/Products/Images/42/235838/Slider/8.Matthanbongdem-1020x570.jpg"
            },
            new Phone
            {
                Id = 7,
                Model = "Samsung Galaxy S21",
                Brand = "Samsung",
                ProductLine = "Galaxy",
                Color = "Phantom Black",
                BasePrice = 899.99m,
                Description = "High-end Android phone",
                ImageUrl = "https://cdn.tgdd.vn/Products/Images/42/235838/samsung-galaxy-s22-ultra-1-1.jpg",
                Discount = 0.1m,
                ProductImage= "https://cdn.tgdd.vn/Products/Images/42/235838/Slider/s22-ultra-1020x570.jpg,https://cdn.tgdd.vn/Products/Images/42/235838/Slider/samsung-galaxy-s22-ultra-1020x570.jpg,https://cdn.tgdd.vn/Products/Images/42/235838/Slider/2.ButSpen-1020x570.jpg,https://cdn.tgdd.vn/Products/Images/42/235838/Slider/8.Matthanbongdem-1020x570.jpg"
            },
            new Phone
            {
                Id = 8,
                Model = "Samsung Galaxy S20",
                Brand = "Samsung",
                ProductLine = "Galaxy",
                Color = "Phantom Black",
                BasePrice = 899.99m,
                Description = "High-end Android phone",
                ImageUrl = "https://cdn.tgdd.vn/Products/Images/42/235838/samsung-galaxy-s22-ultra-1-1.jpg",
                ProductImage= "https://cdn.tgdd.vn/Products/Images/42/235838/Slider/s22-ultra-1020x570.jpg,https://cdn.tgdd.vn/Products/Images/42/235838/Slider/samsung-galaxy-s22-ultra-1020x570.jpg,https://cdn.tgdd.vn/Products/Images/42/235838/Slider/2.ButSpen-1020x570.jpg,https://cdn.tgdd.vn/Products/Images/42/235838/Slider/8.Matthanbongdem-1020x570.jpg"
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
