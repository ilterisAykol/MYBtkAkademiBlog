namespace MYBtkAkademiBlog.WebApi.Entities
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string CoverImageUrl { get; set; }
        public string MainImageUrl { get; set; }
        public string ArticleContent { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
