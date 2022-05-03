using Thales.Models;

namespace Thales.DataTransferObjects
{
    public record NovelDTO(
        int NovelId,
        string Title,
        int AuthorId)
    {
        public NovelDTO(Novel novel)
            : this(novel.NovelId, novel.Title, novel.AuthorId)
        {
        }
    }
}
