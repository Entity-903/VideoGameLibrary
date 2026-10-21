namespace Models
{
	public class VideoGame
	{
		public string Title { get; set; }
		public string Platform { get; set; }
		public string Genre {  get; set; }
		public string ESRBRating { get; set; }
		public int Year { get; set; }
		public string Image {  get; set; }
		public string? LoanedTo {  get; set; }
		public DateOnly? LoanDate {  get; set; }

		public VideoGame(string title, string platform, string genre, string esrbRating, int year, string image, string? loanedTo = null, DateOnly? loanDate = null)
		{
			Title = title;
			Platform = platform;
			Genre = genre;
			ESRBRating = esrbRating;
			Year = year;
			Image = image;
			LoanedTo = loanedTo;
			LoanDate = loanDate;
		}
	}
}
