using GraphQL_Project.DBContext;
using GraphQL_Project.Query_class;
using GraphQL_Project.Query_Mutation_class;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPooledDbContextFactory<AdventureWorksLt2022Context>(o => o.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")));

// Configure CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowApp",
        builder =>
        {
            builder.WithOrigins("http://localhost:3000") // Angular app's origin
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

builder.Services.AddGraphQLServer().
    AddQueryType<Query>().
    AddProjections().
    AddFiltering().
    AddSorting().
    AddMutationType<Mutation>().
    RegisterDbContext<AdventureWorksLt2022Context>(DbContextKind.Pooled);



var app = builder.Build();

app.UseCors("AllowApp");

app.MapGet("/", () => "Hello World!");

app.MapGraphQL();

app.Run();

