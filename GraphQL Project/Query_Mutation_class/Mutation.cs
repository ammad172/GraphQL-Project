using GraphQL_Project.DBContext;
using GraphQL_Project.Repositry;


namespace GraphQL_Project.Query_Mutation_class
{
    public class Mutation
    {
        public readonly AdventureworkRepo _adventureworkRepo;

        public Mutation(AdventureworkRepo adventureworkRepo)
        {
            _adventureworkRepo = adventureworkRepo;
        }

        public async Task<Product> AddProduct(string color, string name, string price, decimal listPrice, decimal Weight, decimal StandardCost , int ProductCategoryId)
        {
            Product product = new Product()
            {
                Color = "",
                Name = "",
                ListPrice = listPrice,
                ModifiedDate = DateTime.Now,
                Weight = Weight,
                StandardCost = StandardCost,
                ProductCategoryId = ProductCategoryId
            };

            var prod = await _adventureworkRepo.AddProduct(product);

            return prod;
        }
    }
}
