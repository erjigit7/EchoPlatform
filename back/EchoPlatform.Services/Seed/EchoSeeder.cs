using EchoPlatform.Domain.Entities;
using EchoPlatform.Inrastructure.Persistance;

namespace EchoPlatform.Inrastructure.Seed
{
    internal class EchoSeeder(ApplicationDbContext dbContext) : IEchoSeeder
    {
        public async Task Seed()
        {
            if (await dbContext.Database.CanConnectAsync())
            {
                if (!dbContext.Users.Any())
                {
                    var users = GetUsers();
                    dbContext.Users.AddRange(users);
                    await dbContext.SaveChangesAsync();
                }
            }
        }

        private IEnumerable<User> GetUsers()
        {
            List<User> users = [
                new(){
                    FirstName = "Erjigit",
                    LastName = "Batyrbekov",
                    Email = "asdasdad@err.com",
                    Password = "Password",
                    registration_date = DateTime.Now,
                }
                ];

            return users;
        }
    }
}
