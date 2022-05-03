using Thales.Models;

namespace Thales.Database
{
    public class DataInitialize
    {
        public static void Initialize(NovelContext context)
        {
            context.Database.EnsureCreated();
            if (context.Novels.Any())
            {
                return;
            }
            var authors = new Author[]
            {
                new Author { FirstMidName = "Quan Trung", LastName = "La" },
                new Author { FirstMidName = "Thua An", LastName = "Ngo" }
            };
            foreach (Author author in authors)
            {
                context.Authors.Add(author);
            }
            context.SaveChanges();

            var novels = new Novel[]
            {
                new Novel { Title = "Tam Quoc Chi", AuthorId = 1 },
                new Novel { Title = "Tay Du Ky", AuthorId = 2 }
            };
            foreach (Novel novel in novels)
            {
                context.Novels.Add(novel);
            }
            context.SaveChanges();
        }
    }
}
