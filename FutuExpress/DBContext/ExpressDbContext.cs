using FutuExpress.Models;
using System.Data.Entity;

namespace FutuExpress.DBContext
{
    public class ExpressDbContext : DbContext
    {
        static ExpressDbContext()
        {
            Database.SetInitializer<ExpressDbContext>(null);
        }

        public ExpressDbContext()
            : this("Express")
        {
        }

        public ExpressDbContext(string namedConnection)
            : base(namedConnection)
        {
        }

        /// <summary>
        /// Users
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Issue Log Work
        /// </summary>
        public DbSet<IssueLogWork> IssueLogWorks { get; set; }

        /// <summary>
        /// Issue
        /// </summary>
        public DbSet<Issue> Issues { get; set; }

        /// <summary>
        /// Sprint 
        /// </summary>
        public DbSet<Sprint> Sprints { get; set; }

        /// <summary>
        /// 级联删除
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Issue>()
                .HasMany<IssueLogWork>(c => c.IssueLogWorks)
                .WithOptional(x => x.Issue)
                .WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Sprint>()
                .HasMany<Issue>(c => c.Issues)
                .WithOptional(x => x.Sprint)
                .WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasMany<IssueLogWork>(c => c.IssueLogWorks)
                .WithOptional(x => x.User)
                .WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);
        }
    }
}
