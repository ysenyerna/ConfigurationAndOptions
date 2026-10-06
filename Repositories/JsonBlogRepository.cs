using System.Text.Json;

public class JsonBlogRepository : IBlogRepository
{

	const string dataFilePath = "data/posts.json";
	private readonly List<Post> posts = [];

	public JsonBlogRepository()
	{
		// Load the posts in the constructor
		string existingJson = File.ReadAllText(dataFilePath);
		if (!string.IsNullOrWhiteSpace(existingJson))
		{
			posts = JsonSerializer.Deserialize<List<Post>>(existingJson) ?? [];
		}
	}


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
		// Write updated post data to the JSON file
		string json = JsonSerializer.Serialize(
			posts,
			new JsonSerializerOptions
			{
				WriteIndented = true
			});


		File.WriteAllText(dataFilePath, json);

	}

}