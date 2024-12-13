using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moviey_Back.Interfaces;
using Moviey_Back.Models;

namespace Moviey_Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        public ICommentRepo CommentRepo { get; }
        
        public CommentController(ICommentRepo _commentRepo)
        {
            CommentRepo = _commentRepo;
        }

        [HttpGet]
        public IActionResult GetAllComments()
        {
            return Ok(CommentRepo.GetAll());
        }

        [HttpGet("productId")]
        public IActionResult GetCommentsByProductId(int id) {
            return Ok(CommentRepo.GetAllByProdId(id));
        }

        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            CommentRepo.Add(comment);
            CommentRepo.Save();
            return Ok();
        }

    }
}
