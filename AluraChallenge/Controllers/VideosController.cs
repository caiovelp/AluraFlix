using AluraChallenge.Data;
using AluraChallenge.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideosController : ControllerBase
    {
        private VideoContext _context;
        public VideosController(VideoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionarVideo([FromBody] Video video)
        {
            _context.Videos.Add(video);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaVideosPorId), new { Id = video.Id }, video);
        }

        [HttpGet]
        public IEnumerable<Video> RecuperaFilmes()
        {
            return _context.Videos;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaVideosPorId(int id)
        {
            Video video = _context.Videos.FirstOrDefault(video => video.Id == id);
            if (video != null)
            {
                return Ok(video);
            } else
            {
                return NotFound();
            }

        }

        [HttpPut("{id}")]
        public IActionResult AtualizaVideo(int id, [FromBody] Video videoNovo)
        {
            Video video = _context.Videos.FirstOrDefault(video => video.Id == id);
            if (video == null)
            {
                return NotFound();
            }
            else
            {
                video.Titulo = videoNovo.Titulo;
                video.Descricao = videoNovo.Descricao;
                video.URL = videoNovo.URL;
                _context.SaveChanges();
                return NoContent();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaVideo(int id)
        {
            Video video = _context.Videos.FirstOrDefault(video => video.Id == id);
            if (video == null)
            {
                return NotFound();
            }
            else
            {
                _context.Remove(video);
                _context.SaveChanges();
                return NoContent();
            }
        }
    }
}
