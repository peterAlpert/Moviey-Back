namespace Moviey_Back.Models
{
   
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string[] Cast { get; set; }
        public string ImgUrl { get; set; }
        public int Rating { get; set; }
    }
}
