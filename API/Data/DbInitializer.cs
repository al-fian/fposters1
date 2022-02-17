using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data
{
    public static class DbInitializer
    {

        public static async Task Initialize(StoreContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new User
                {
                    UserName = "bob",
                    Email = "bob@test.com"
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@test.com"
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] {"Member", "Admin"});
            }
            
            if (context!.Products!.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Mbappe Running With Ball",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "/images/products/kylian_mbappe_km3001km.png",
                    Player = "Mbappe",
                    Type = "Wallpaper",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mbappe Tackling Ball",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 15000,
                    PictureUrl = "/images/products/kylian_mbappe_km3002km.png",
                    Player = "Mbappe",
                    Type = "Poster",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mbappe Passing Ball",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/kylian_mbappe_km3003km.png",
                    Player = "Mbappe",
                    Type = "Poster",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mbappe Stopping Ball",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 30000,
                    PictureUrl = "/images/products/kylian_mbappe_km3004km.png",
                    Player = "Mbappe",
                    Type = "Wallpaper",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mbappe Jumping for Ball",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 25000,
                    PictureUrl = "/images/products/kylian_mbappe_km3005km.png",
                    Player = "Mbappe",
                    Type = "Wallpaper",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Lukaku Heading Ball for Goal",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 12000,
                    PictureUrl = "/images/products/lukaku_rl3001l.png",
                    Player = "Lukaku",
                    Type = "Wallpaper",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Lukaku Back Away",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1000,
                    PictureUrl = "/images/products/lukaku_rl3002l.png",
                    Player = "Lukaku",
                    Type = "Poster",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Lukaku Celebrating Goal",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 8000,
                    PictureUrl = "/images/products/lukaku_rl3003l.png",
                    Player = "Lukaku",
                    Type = "Poster",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Lukaku Navigating Ball",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/lukaku_rl3004l.png",
                    Player = "Lukaku",
                    Type = "Poster",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Lukaku Heading Goal",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1800,
                    PictureUrl = "/images/products/lukaku_rl3005l.png",
                    Player = "Lukaku",
                    Type = "Poster",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mane Rolling Ball",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/mane_poster_sm3001m.png",
                    Player = "Mane",
                    Type = "Wallpaper",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mane Running after Goal",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1600,
                    PictureUrl = "/images/products/mane_poster_sm3002m.png",
                    Player = "Mane",
                    Type = "Poster",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mane Running Ball",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1400,
                    PictureUrl = "/images/products/mane_poster_sm3003m.png",
                    Player = "Mane",
                    Type = "Wallpaper",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mane Sliding after Goal",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 25000,
                    PictureUrl = "/images/products/mane_poster_sm3004m.png",
                    Player = "Mane",
                    Type = "Wallpaper",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mane Shooting for Goal",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 18999,
                    PictureUrl = "/images/products/mane_poster_sm3005m.png",
                    Player = "Mane",
                    Type = "Poster",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mendy Throwing Ball",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 19999,
                    PictureUrl = "/images/products/mendy_em3001dy.png",
                    Player = "Mendy",
                    Type = "Poster",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mendy Catching Ball",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Price = 15000,
                    PictureUrl = "/images/products/mendy_em3002dy.png",
                    Player = "Mendy",
                    Type = "Wallpaper",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mendy Sending Ball Off",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/mendy_em3003dy.png",
                    Player = "Mendy",
                    Type = "Wallpaper",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mendy Stopping Ball",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/mendy_em3004dy.png",
                    Player = "Mendy",
                    Type = "Wallpaper",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mendy Flying for Ball",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/mendy_em3005dy.png",
                    Player = "Mendy",
                    Type = "Wallpaper",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Messi Celebrating Goal",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/messi_poster_lm3001a.png",
                    Player = "Messi",
                    Type = "Poster",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Messi Showing Off Jersey",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/messi_poster_lm3002a.png",
                    Player = "Messi",
                    Type = "Wallpaper",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Messi Running Celebrating Goal",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/messi_poster_lm3003a.png",
                    Player = "Messi",
                    Type = "Wallpaper",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Messi Controlling Ball",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/messi_poster_lm3004a.png",
                    Player = "Messi",
                    Type = "Wallpaper",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Messi Shooting Ball",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/messi_poster_lm3005a.png",
                    Player = "Messi",
                    Type = "Poster",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Salah Curving Ball",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/moh_salah_m3001s.png",
                    Player = "Salah",
                    Type = "Poster",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Salah Side-Shooting Ball",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/moh_salah_m3002s.png",
                    Player = "Salah",
                    Type = "Poster",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Salah Controlling Ball",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/moh_salah_m3003s.png",
                    Player = "Salah",
                    Type = "Wallpaper",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Salah Running Ball",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/moh_salah_m3004s.png",
                    Player = "Salah",
                    Type = "Wallpaper",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Salah Heading for Goal",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/moh_salah_m3005s.png",
                    Player = "Salah",
                    Type = "Poster",
                    QuantityInStock = 100
                },
            };

            foreach (var product in products)
            {
                context!.Products!.Add(product);
            }

            context.SaveChanges();
        }
    }
}