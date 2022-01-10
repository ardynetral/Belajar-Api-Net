namespace BelajarDotNet
{
    public class MoviesResp
    {
        public DateTime Date { get; set; }

        public String Title { get; set; }
        public String Overview { get; set; }
        public TagsResp Tags { get; set; }
    }
}
