using GraphQL_Project.DBContext;

namespace GraphQL_Project.Query_class
{
    public class Query
    {

        [UsePaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Customer> GetCustomers(AdventureWorksLt2022Context context) =>
            context.Customers;

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Product> GetProducts(AdventureWorksLt2022Context context) =>
           context.Products;


        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public IQueryable<ProductCategory> GetProductsCategories(AdventureWorksLt2022Context context) =>
     context.ProductCategories;
    }
}
