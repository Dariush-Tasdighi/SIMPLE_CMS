namespace Models
{
	public class DatabaseContext : System.Data.Entity.DbContext
	{
		static DatabaseContext()
		{
			System.Data.Entity.Database.SetInitializer
		(new System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>());
		}

		public DatabaseContext() : base()
		{
		}

		public System.Data.Entity.DbSet<User> Users { get; set; }

		public System.Data.Entity.DbSet<Layout> Layouts { get; set; }

		public System.Data.Entity.DbSet<Post> Posts { get; set; }

		public System.Data.Entity.DbSet<PostCategory> PostCategories { get; set; }

		public System.Data.Entity.DbSet<Page> Pages { get; set; }

		public System.Data.Entity.DbSet<MenuItem> MenuItems { get; set; }

		public System.Data.Entity.DbSet<Slide> Slides { get; set; }

	}
}
