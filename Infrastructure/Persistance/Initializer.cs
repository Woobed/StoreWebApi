namespace Persistance
{
    public class Initializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

        }
    }
}
