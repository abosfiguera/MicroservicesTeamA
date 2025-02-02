﻿using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace ProveedoresService.Data
{
    public class DesignTimeProveedorContextFactory : IDesignTimeDbContextFactory<ProveedorContext>
    {
        public ProveedorContext CreateDbContext(string[] args)
        {
            var dbContextBuilder = new DbContextOptionsBuilder<ProveedorContext>();

            // this connection string is for local SQL database 
            // This database instance is generally installed with default Visual Studio components
            // If you use SQL Server Express, change connection string appropriately
            // NOTE: Do not hardcode connection strings in code.  
            // This is hard coded here to limit scope of demo.
            //var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Producto; Integrated Security=True;";
            var connectionString = "Server=tcp:serverproductos.database.windows.net,1433;Initial Catalog=EquipoA;Persist Security Info=False;User ID=admin22;Password=Productos22;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;;";

            dbContextBuilder.UseSqlServer(connectionString);
            return new ProveedorContext(dbContextBuilder.Options);
        }
    }
}
