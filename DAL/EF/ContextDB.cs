using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class ContextDB : DbContext
    { 
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }    
        public DbSet<Product> Products { get;set; }
        public DbSet<ProductIMG> ProductImages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ParameterValue> parameterValues{ get; set; }
        public DbSet<ParameterName> ParameterNames { get; set; }

        public ContextDB(string connectionString) : base(GetOptions(connectionString))
        {
            Database.EnsureDeleted();   
            Database.EnsureCreated();
        }
        private static DbContextOptions GetOptions(string ConnectionString)
        {
            return new DbContextOptionsBuilder().UseSqlServer(ConnectionString).Options;
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<OrderProduct>()
                .HasOne(op => op.Order)
                .WithMany(o => o.orderProducts)
                .HasForeignKey(op => op.OrderID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Brand>().HasData(
                new Brand { id = 1, name = "Xiaomi", description = "Xiaomi desc" },
                new Brand { id = 2, name = "Meizu", description = "Meizu desc" },
                new Brand { id = 3, name = "Samsung", description = "Samsung desc" });

            modelBuilder.Entity<Category>().HasData(
                new Category { id=1,description = "Смартфоны.описание категории смартфоны",languageId = 1 ,name = "Смартфоны"});

            modelBuilder.Entity<Currency>().HasData(
                new Currency { id = 1, curencyRate = 1, currencySymbol = '₴', mainCurrency = true,name = "Гривна",shortName = "грн" });
            
            modelBuilder.Entity<Language>().HasData(
                new Language { id = 1, name= "Русский",shortName="RU"});

            modelBuilder.Entity<ParameterName>().HasData(
                new ParameterName { Id = 1,LanguageId = 1,Name="Цвет"},
                new ParameterName { Id = 2, LanguageId = 1, Name = "Дисплей" },
                new ParameterName { Id = 3, LanguageId = 1, Name = "Память" });

            modelBuilder.Entity<Product>().HasData(
                new Product { id = new Guid("154357ce-1d29-43ed-9543-eafa0171faf8"),BrandID = 1,CategoryID = 1, count = 100,desc = "Описание телефона",groupBindingId = new Guid(),LanguageID = 1,
                price = 3100,name = "Xiaomi Redmi 9a"});

            modelBuilder.Entity<ParameterValue>().HasData(
                new ParameterValue { Id = 1, LanguageId = 1, ParameterNameId = 3, Value = "32гб",ProductId = new Guid("154357ce-1d29-43ed-9543-eafa0171faf8")});



            modelBuilder.Entity<Product>().HasOne(p => p.Language).WithMany(l => l.products).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Order>().HasOne(o => o.OrderStatus).WithMany(s => s.Orders).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<OrderProduct>().HasOne(o => o.Product).WithMany().OnDelete(DeleteBehavior.NoAction);


            base.OnModelCreating(modelBuilder);
        }
    }
}
