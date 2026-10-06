using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

public class CreateController : Controller
{

	private IBlogRepository _blogRepository;

	public CreateController(IBlogRepository blogRepository)
	{
		_blogRepository = blogRepository;
	}

    [HttpPost]
    public IActionResult CreatePost(Post post)
    {

		// Add the post to the repository
		post.Id = _blogRepository.GetAll().ToList().Count();
		_blogRepository.Add(post);
		_blogRepository.Save();



		// Return to home page
        return RedirectToAction(nameof(Success));
    }

	public IActionResult Success()
	{
		return Redirect("/Index");
	}
}
