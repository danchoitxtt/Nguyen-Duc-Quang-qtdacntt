using System;
using System.Data.Entity;
using CoffeeManagement.DTOs;

namespace CoffeeManagement.DAO
{
	public class CoffeeDbContext : DbContext
	{
		private static string _dbName = "COFFEE_MANAGEMENT_DB";

		// DbSets
		public DbSet<BasicSalary> BasicSalaries { get; set; }
		public DbSet<Bill> Bills { get; set; }
		public DbSet<Item> Items { get; set; }
		public DbSet<Shift> Shifts { get; set; }
		public DbSet<Table> Tables { get; set; }
		public DbSet<Unit> Units { get; set; }
		public DbSet<User> Users { get; set; }

		public CoffeeDbContext() : base(_dbName)
		{
			// switch on these lines to drop and create new database when model changes.
			Database.SetInitializer(new DbInitializer());
			Database.Initialize(false);
			if (Database.CreateIfNotExists())
			{
				InitDatabase();
			}
		}


		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Item>()
				.HasRequired(item => item.Unit)
				.WithMany(unit => unit.Items)
				.HasForeignKey(item => item.UnitId);

			base.OnModelCreating(modelBuilder);
		}

		public class DbInitializer : DropCreateDatabaseIfModelChanges<CoffeeDbContext>
		{
			protected override void Seed(CoffeeDbContext context)
			{
				InitDatabase();
				base.Seed(context);
			}
		}

		public static void InitDatabase()
		{
			CoffeeDbContext context = new CoffeeDbContext();
			// Init database with context
			context.Users.Add(new User
			{
				UserName = "admin",
				Password = "admin",
				FullName = "Admin",
				Level = Utilities.AppEnum.UserLevel.Admin
			});

			context.Users.Add(new User
			{
				UserName = "worker",
				Password = "123",
				FullName = "Worker",
				Level = Utilities.AppEnum.UserLevel.Worker

			});

			for (int i = 1; i <= 20; i++)
			{
				context.Tables.Add(new Table {Name = "Bàn " + i, IsOccupied = false});
			}

			context.SaveChanges();
		}
	}
}
