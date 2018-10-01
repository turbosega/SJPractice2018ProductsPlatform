using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class DatabaseSeed
    {
        public static void Seed(StoreContext _storeContext)
        {
            _storeContext.Database.Migrate();
        }
    }
}