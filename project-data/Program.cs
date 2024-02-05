using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using project_data.Context;
using project_data.Repositories;
using project_data.Services;

var builder = Host.CreateDefaultBuilder().ConfigureServices(Services =>
{

    Services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MahdiAhmadi\Desktop\Database_project\project-data\project-data\Data\databas.mdf;Integrated Security=True;Connect Timeout=30"));

    Services.AddScoped<AddressRepository>();
    Services.AddScoped<CategoryRepository>();
    Services.AddScoped<CustomerRepository>();
    Services.AddScoped<ProducRepository>();
    Services.AddScoped<RoleRepository>();



    Services.AddScoped<AddressService>();
    Services.AddScoped<CategoryService>();
    Services.AddScoped<CustomerService>();
    Services.AddScoped<ProductService>();
    Services.AddScoped<RoleServices>();


}).Build();
