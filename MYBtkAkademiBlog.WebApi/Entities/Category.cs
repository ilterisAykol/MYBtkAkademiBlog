namespace MYBtkAkademiBlog.WebApi.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Article> Articles { get; set; } // bu kategoriye ait makaleleri gösterir
    }
}
