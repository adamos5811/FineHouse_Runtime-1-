using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Microsoft.Azure.Mobile.Server;
using Microsoft.Azure.Mobile.Server.Tables;
using FineHouseService.DataObjects;



using Microsoft.AspNet.Identity.EntityFramework;

namespace FineHouseService.Models
{
    public class FineHouseContext : IdentityDbContext<User>
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to alter your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        private const string connectionStringName = "Name=MS_TableConnectionString";

        public FineHouseContext() : base(connectionStringName)
        {
            Configuration.ProxyCreationEnabled = false; 
            Configuration.LazyLoadingEnabled = false;
          
        }

        public static FineHouseContext Create()
        {
            return new FineHouseContext();
        }

        //public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)

        {
                
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Add(
                new AttributeToColumnAnnotationConvention<TableColumnAttribute, string>(
                    "ServiceTableColumn", (property, attributes) => attributes.Single().ColumnType.ToString()));
           
        }
        
    }

}
