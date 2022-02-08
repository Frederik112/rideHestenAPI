namespace RideHestenAPI
{
    public class Horse
    {
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public int Age { get; set; }
        public string? Race { get; set; }
        public double Height { get; set; }
        public string? DadName { get; set; }
        public string? MomDadName { get; set; }
        public ICollection<string> PictureUrls { get; set; } = new List<string>();
        public ICollection<string> YoutubeUrls { get; set; } = new List<string>();
        public double PriceMinimum { get; set; }
        public double PriceMaximum { get; set; }

    }
}