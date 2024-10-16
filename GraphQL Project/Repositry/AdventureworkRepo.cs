using GraphQL_Project.DBContext;
using System.Data.Entity.Infrastructure;

namespace GraphQL_Project.Repositry
{
    public class AdventureworkRepo
    {
        public AdventureWorksLt2022Context _dbContextFactory;
        public AdventureworkRepo(AdventureWorksLt2022Context dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<Product> AddProduct(Product product)
        {
            using (AdventureWorksLt2022Context context = _dbContextFactory)
            {

                await context.AddAsync(product);
                await context.SaveChangesAsync();
                return product;

            }
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            using (AdventureWorksLt2022Context context = _dbContextFactory)
            {

                context.Update(product);
                await context.SaveChangesAsync();
                return product;

            }
        }

        public async Task<Product> RemoveProduct(Product product)
        {
            using (AdventureWorksLt2022Context context = _dbContextFactory)
            {

                context.Remove(product);
                await context.SaveChangesAsync();
                return product;

            }
        }
    }
}
