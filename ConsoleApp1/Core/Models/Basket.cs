namespace Core.Models
{
	public class Basket
	{
		public List<BasketItem> Items { get; set; }
		public int TotalCount { get; set; }
		public string DiscountCode { get; set; }
	}
}
