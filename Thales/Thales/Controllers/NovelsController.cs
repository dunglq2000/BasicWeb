#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Thales.Database;
using Thales.DataTransferObjects;
using Thales.Models;

namespace Thales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NovelsController : ControllerBase
    {
        private readonly NovelContext _context;
        private readonly ILogger _logger;

        public NovelsController(ILogger<NovelsController> logger, NovelContext context)
        {
            _logger = logger;
            _context = context;
        }

        // GET: api/Novels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NovelDTO>>> GetNovels()
        {
            return await _context.Novels
                .Select(x => new NovelDTO(x))
                .ToListAsync();

        }

        // GET: api/Novels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NovelDTO>> GetNovel(int id)
        {
            var novel = await _context.Novels.FindAsync(id);

            if (novel == null)
            {
                return NotFound();
            }

            return new NovelDTO(novel);
        }

        // PUT: api/Novels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNovel(int id, NovelDTO novel)
        {
            if (id != novel.NovelId)
            {
                return BadRequest();
            }

            _context.Entry(novel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NovelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Novels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<NovelDTO>> Create([FromForm]string title, [FromForm]int authorId)
        {
            _logger.LogInformation($"Title: {title}\nAuthor ID: {authorId}");
            var newNovel = new Novel
            {
                Title = title,
                AuthorId = authorId,
            };

            _context.Novels.Add(newNovel);
            await _context.SaveChangesAsync();

            //return CreatedAtAction(
              //  nameof(GetNovel),
              //  new { id = newNovel.NovelId },
              //  new NovelDTO(newNovel));
            return new NovelDTO(newNovel);
        }

        // DELETE: api/Novels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNovel(int id)
        {
            var novel = await _context.Novels.FindAsync(id);
            if (novel == null)
            {
                return NotFound();
            }

            _context.Novels.Remove(novel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NovelExists(int id)
        {
            return _context.Novels.Any(e => e.NovelId == id);
        }
    }
}
