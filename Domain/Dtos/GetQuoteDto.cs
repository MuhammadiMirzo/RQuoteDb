namespace Domain.Dtos;

public class GetQuoteDto
{
        public int Id { get; set; }
    public string QuoteText { get; set; }
    public string Author { get; set; }
    public string QuoteImage { get; set; } 
    public int CategoryId { get; set; }
}