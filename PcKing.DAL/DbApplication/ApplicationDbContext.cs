using Microsoft.EntityFrameworkCore;
using PcKing.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PcKing.DAL.DbApplication
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext() { }
		public virtual DbSet<Role> Roles { get; set; }
		public virtual DbSet<Cart> Carts { get; set; }
		public virtual DbSet<CartDetail> CartDetails { get; set; }
		public virtual DbSet<Category> Categories { get; set; }
		public virtual DbSet<Brand> Brands { get; set; }
		public virtual DbSet<CustomAttribute> CustomAttributes { get; set; }
		public virtual DbSet<Value> Values { get; set; }
		public virtual DbSet<Image> Images { get; set; }
		public virtual DbSet<Order> Orders { get; set; }
		public virtual DbSet<OrderDetail> OrderDetails { get; set; }
		public virtual DbSet<PaymentOrder> PaymentOrders { get; set; }
		public virtual DbSet<Payment> Payments { get; set; }
		public virtual DbSet<Product> Products { get; set; }
		public virtual DbSet<ReturnOrder> ReturnOrders { get; set; }
		public virtual DbSet<User> Users { get; set; }
		public virtual DbSet<Comment> Comments { get; set; }
		public virtual DbSet<StatusOrder> StatusOrders { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("Data Source=DESKTOP-L9TSC4C\\SQLEXPRESS;Initial Catalog=PcKing;Integrated Security=True");

			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
	}
}
