namespace jurnalmodul9_1302213109
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public List<string> Stars { get; set; }

        public Movie(string title, string director, string description, List<string> stars)
        {
            this.Title = title;
            this.Director = director;
            this.Description = description;
            this.Stars = stars;
        }
    }
}