namespace Thales.Models
{
    public class Novel
    {
        public int NovelId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
