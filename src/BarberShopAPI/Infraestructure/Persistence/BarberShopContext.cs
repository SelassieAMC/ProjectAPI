using BarberShopAPI.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BarberShopAPI.Infraestructure.Persistence
{
    public class BarberShopContext : DbContext
    {
        public BarberShopContext(DbContextOptions<BarberShopContext> options) :base(options)
        {        
        }
        #region DbSet
        public DbSet<Catalog> Catalogs {get; set; }
        public DbSet<CatalogMedia> CatalogsMedia {get; set; }
        public DbSet<Category> Categories {get; set; }
        public DbSet<Clasification> Clasifications {get; set; }
        public DbSet<Customer> Customers {get; set; }
        public DbSet<DocumentType> DocumentTypes {get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Service> Services { get; set; }
        #endregion DbSet
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {                        
            modelBuilder.Entity<Person>()            
                        .HasOne(p => p.DocumentType)
                        .WithMany(dt => dt.DocumentTypePersons)
                        .HasForeignKey(p => p.DocumentTypeID);
            
            modelBuilder.Entity<Employee>()
                        .HasOne<Person>(e => e.Person);
            
            modelBuilder.Entity<Customer>()
                        .HasOne<Person>(c => c.Person);

            modelBuilder.Entity<Catalog>( c => {                
                c.HasOne<Clasification>( c => c.Clasification)
                    .WithMany(c => c.ClasificationCatalogs)
                    .HasForeignKey(c => c.ClasificationID);

                c.HasOne<Employee>(c => c.Employee)
                    .WithMany(e => e.EmployeeCatalogs)
                    .HasForeignKey(c => c.EmployeeID);
            });

            modelBuilder.Entity<CatalogMedia>()
                        .HasOne<Catalog>(c => c.Catalog);                        

            modelBuilder.Entity<EmployeeRole>( er => {
                er.HasKey(er => new { er.EmployeeID, er.RoleID});

                er.HasOne(er => er.Role)
                    .WithMany(r => r.RolesEmployee)
                    .HasForeignKey(er => er.RoleID);

                er.HasOne(er => er.Employee)
                    .WithMany(e => e.EmployeeRoles)
                    .HasForeignKey(er => er.EmployeeID);
            });

            modelBuilder.Entity<EmployeeSubordinate>( es => {
                es.HasKey(es => new { es.EmployeeID, es.subordinateID});

                es.HasOne(es => es.Employee)
                    .WithMany(e => e.Subordinates)
                    .HasForeignKey(es => es.EmployeeID)
                    .OnDelete(DeleteBehavior.NoAction);

                // es.HasOne (es => es.Subordinate)
                //     .WithMany(s => s.Subordinates)
                //     .HasForeignKey(es => es.subordinateID);
            });

            modelBuilder.Entity<ServiceEmployee>( se => {
                se.HasKey(se => new { se.EmployeeID, se.ServiceID});

                se.HasOne(se => se.Employee)
                    .WithMany(e => e.QualifiedServices)
                    .HasForeignKey(se => se.EmployeeID);

                se.HasOne(se => se.Service)
                    .WithMany(s => s.QualifiedEmployees)
                    .HasForeignKey(se => se.ServiceID);
            });

            modelBuilder.Entity<ServiceCategory>( sc => {
                sc.HasKey(sc => new {sc.ServiceID, sc.CategoryID});

                sc.HasOne(sc => sc.Service)
                    .WithMany(s => s.ServiceCategories)
                    .HasForeignKey(sc => sc.ServiceID);

                sc.HasOne(sc => sc.Category)
                    .WithMany(c => c.CategoryServices)
                    .HasForeignKey(sc => sc.CategoryID);
            });

            modelBuilder.Entity<ClasificationCategory>(cc => {
                cc.HasKey(cc => new {cc.ClasificationID, cc.CategoryID});

                cc.HasOne(cc => cc.Clasification)
                    .WithMany(c => c.ClasificationCategories)
                    .HasForeignKey(cc => cc.ClasificationID);

                cc.HasOne(cc => cc.Category)
                    .WithMany(c => c.CategoryClasifications)
                    .HasForeignKey(cc => cc.CategoryID);
            });          
        }
    }
}