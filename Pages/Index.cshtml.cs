using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MicroBlog.Pages;

public class IndexModel : PageModel
{

	private IBlogRepository _blogRepository;
	public List<Post> PostData = [];


	public IndexModel(IBlogRepository blogRepository)
	{
		_blogRepository = blogRepository;
	}

    public void OnGet()
    {
		// Retrieve post data
		PostData = _blogRepository.GetAll().ToList();

    }
}
