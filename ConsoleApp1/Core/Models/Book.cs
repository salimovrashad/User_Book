namespace Core.Models
{
	public class Book
	{
        public Author Author { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public int Price { get; set; }
    }
}
