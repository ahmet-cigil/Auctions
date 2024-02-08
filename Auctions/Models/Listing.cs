using System;
namespace Auctions.Models
{
	public class Listing
	{
		public int Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public double Price { get; set; }

		public string ImagePath { get; set; }

		public bool IsSold { get; set; }

		[Required]

		public string IdentityUserId? { get; set; }
		[Foreignkey("IdentityUserId")]

		public IdentityUser? User { get; set; }

		public List <Bid>? Bids { get; set; }

		public List <Comment>? Comments { get; set; }
	}
}

