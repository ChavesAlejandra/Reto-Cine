using Microsoft.AspNetCore.Mvc;
using back.Models;

namespace back.Controllers;


[ApiController]
[Route("[controller]")]

public class CommentController : ControllerBase
{
    public static List<Comment> comments = new List<Comment>();
    
    [HttpGet]
    public ActionResult<IEnumerable<Comment>> GetComments () { return Ok(comments); }
    
    [HttpGet("film/{filmID}")]
    public ActionResult<IEnumerable<Comment>> GetCommentsByFilm (int filmID) { return Ok(comments.FindAll(el => el._filmID == filmID)); }

    [HttpPost("film/{filmID}")]
    public ActionResult<Comment> AddComment ([FromBody] Comment comment, int filmID)
    {
        comment._filmID = filmID;
        comments.Add(comment);
        return Ok(comment);
    }

    [HttpDelete("id/{id}")]
    public ActionResult<Comment> DeleteComment (int id)
    {
        comments.Remove(comments.Find(el => el._id == id));
        return Ok("Comment removal succesful");
    }
}
