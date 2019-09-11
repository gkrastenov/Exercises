namespace Eventures.Data.Seeding
{
    using System;
    using System.Threading.Tasks;

    public interface ISeeder
    {
        Task SeedAsync(EventureDbContext dbContext, IServiceProvider serviceProvider);
    }
}
