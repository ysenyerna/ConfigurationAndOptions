using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MicroBlog.Pages;

public class DetailsModel : PageModel
{

	private IBlogRepository _blogRepository;
	public Post post = new() { Title = "", Body = ""};

	public DetailsModel(IBlogRepository blogRepository)
	{
		_blogRepository = blogRepository;
	}

    public void OnGet()
    {
		// Retrieve post data
		if (int.TryParse(Request.Query["id"], out int postId))
			post = _blogRepository.GetAll().ToList()[postId];

    }

}
