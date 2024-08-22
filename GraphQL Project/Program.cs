using GraphQL_Project.DBContext;
using GraphQL_Project.Query_class;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPooledDbContextFactory<AdventureWorksLt2022Context>(o => o.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddGraphQLServer().
    AddQueryType<Query>().RegisterDbContext<AdventureWorksLt2022Context>(DbContextKind.Pooled);


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGraphQL();

app.Run();

