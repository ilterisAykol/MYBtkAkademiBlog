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
        public int? CategoryId { get; set; }
        public Category Category { get; set; } // bu makale hangi kategoriye ait onu gösterir
        public bool IsFeatureSlider { get; set; } // bu makale sliderda gösterilecek mi onu gösterir
        public string? FeatureSliderImageUrl { get; set; }
        public string? FeatureImageUrl { get; set; }
    }
}
