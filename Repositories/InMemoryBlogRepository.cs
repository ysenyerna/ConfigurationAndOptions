public class InMemoryBlogRepository : IBlogRepository
{
	private List<Post> posts = [];

	public IEnumerable<Post> GetAll()
		=> posts.AsReadOnly();

	public Post? GetById(int id)
		=> posts.Find(p => p.Id == id);

	public void Add(Post post)
	{
		posts.Add(post);
	}

	public void Save()
	{
		// This repository doesn't need to save anything
		// since the posts are only stored in memory
	}

}