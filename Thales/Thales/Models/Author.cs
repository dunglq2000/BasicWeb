namespace Thales.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstMidName { get; set; }
        public string LastName { get; set; }
        public ICollection<Novel> Novels { get; set; }
        public string FullName
        {
            get
            {
                return LastName + " " + FirstMidName;
            }
        }
    }
}
