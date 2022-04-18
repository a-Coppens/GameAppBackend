using GameAppBackend.Entities;
using GameAppBackend.Models;

namespace GameAppBackend.Migrations
{
    public static class DataSeeder
    {
        public static void Seed(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<UserDataContext>();
            context.Database.EnsureCreated();
            AddData(context);
        }

        private static void AddData(UserDataContext context)
        {
            var user = context.Users.FirstOrDefault();
            if (user != null) return;

            context.Users.Add(new UserModel
            {
                ID = 1,
                UserName = "xdxdxd",
                Email = "test@test.com",
                Password = "$2a$11$ZHFHLuIC.NL4NkzpKIhSBeKQNduZhzRW.aXf9NpouRCiDb.Ulz0pW",
                Salt = "$2a$11$ZHFHLuIC.NL4NkzpKIhSBe"
            });

            context.SaveChanges();
        }
    }
}
