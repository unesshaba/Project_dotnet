using Microsoft.EntityFrameworkCore;
using ShoppingCart.Models;

namespace ShoppingCart.Infrastructure
{
        public class SeedData
        {
                public static void SeedDatabase(DataContext context)
                {
                        context.Database.Migrate();

                        if (!context.Products.Any())
                        {
                Category Parfum = new Category { Name = "Parfum", Slug = "Parfum" };
                Category Movie = new Category { Name = "Movie", Slug = "Movie" };
                Category Manga = new Category { Name = "Manga", Slug = "Manga" };

                context.Products.AddRange(
                     new Product
                     {
                         Name = "Parfum 1",
                         Slug = "Parfum 1",
                         Description = "best Parfum",
                         Price = 2.50M,
                         Category = Parfum,
                         Image = "parfum 1.jpeg"
                     }, new Product
                     {
                         Name = "Parfum 2",
                         Slug = "Parfum 1",
                         Description = "best Parfum",
                         Price = 3.50M,
                         Category = Parfum,
                         Image = "parfum 2.jpeg"
                     }, new Product
                     {
                         Name = "Parfum 3",
                         Slug = "Parfum 3",
                         Description = "best Parfum",
                         Price = 3.50M,
                         Category = Movie,
                         Image = "parfum 3.jpeg"
                     },
                                        new Product
                                        {
                                            Name = "Manga 1",
                                            Slug = "Manga 1",
                                            Description = "best Manga",
                                            Price = 1.50M,
                                            Category = Manga,
                                            Image = "manhwa 1.jpeg"
                                        },
                                        new Product
                                        {
                                            Name = "Manga 2",
                                            Slug = "Manga 2",
                                            Description = "best Manga",
                                            Price = 1.50M,
                                            Category = Manga,
                                            Image = "manhwa 2.jpeg"
                                        },
                                        new Product
                                        {
                                            Name = "Movie 1",
                                            Slug = "Movie 1",
                                            Description = "best Movie",
                                            Price = 3.50M,
                                            Category = Movie,
                                            Image = "movie 1.jpeg"
                                        },
                                        new Product
                                        {
                                            Name = "Movie 2",
                                            Slug = "Movie 2",
                                            Description = "best Movie",
                                            Price = 3.50M,
                                            Category = Movie,
                                            Image = "movie 2.jpeg"
                                        },
                                        new Product
                                        {
                                            Name = "Movie 3",
                                            Slug = "Movie 3",
                                            Description = "best Movie",
                                            Price = 3.50M,
                                            Category = Movie,
                                            Image = "movie 3.jpeg"
                                        },
                                        new Product
                                        {
                                            Name = "Movie 4",
                                            Slug = "Movie 4",
                                            Description = "best Movie",
                                            Price = 3.50M,
                                            Category = Movie,
                                            Image = "movie 4.jpeg"
                                        }   
                                );

                                context.SaveChanges();
                        }
                }
        }
}