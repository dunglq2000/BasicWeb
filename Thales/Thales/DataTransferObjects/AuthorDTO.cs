using Thales.Models;

namespace Thales.DataTransferObjects
{
    public record AuthorDTO(
        int AuthorId,
        string FirstMidName,
        string LastName
        )
    {
        public AuthorDTO(Author author)
            : this(author.AuthorId, author.FirstMidName, author.LastName)
        {
        }
    }
}
