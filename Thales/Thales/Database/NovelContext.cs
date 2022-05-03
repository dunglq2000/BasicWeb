using Microsoft.EntityFrameworkCore;
using Thales.Models;

namespace Thales.Database
{
    public class NovelContext : DbContext
    {
        public DbSet<Novel> Novels { get; set; }
        public DbSet<Author> Authors { get; set; }
        public string DbPath { get; set; }
        public NovelContext() : base()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Combine(path, "novel.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
