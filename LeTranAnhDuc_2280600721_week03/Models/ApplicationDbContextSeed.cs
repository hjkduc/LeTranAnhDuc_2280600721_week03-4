namespace LeTranAnhDuc_2280600721_week03.Models
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedAsync(ApplicationDbContext context)
        {
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category { Id = 1, Name = "Electronics" },
                    new Category { Id = 2, Name = "Books" },
                    new Category { Id = 3, Name = "Clothing" }
                );

                await context.SaveChangesAsync();
            }
        }
    }
}
