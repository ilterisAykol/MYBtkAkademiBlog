using Microsoft.AspNetCore.Mvc;
using MYBtkAkademiBlog.WebUI.Dtos.ArticleDtos;
using Newtonsoft.Json;

namespace MYBtkAkademiBlog.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultSliderComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultSliderComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7040/api/Articles/GetArticlesFeatureSliderByTrue"); // ayrıca await metodu async metodların çağrılması için kullanılır. Api'den veri çekmek için GetAsync() metodunu kullanıyoruz. Bu metod, belirtilen URL'ye bir GET isteği gönderir ve yanıtı döndürür.
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync(); // Api'den gelen veriyi json formatında alıyoruz. ReadAsStringAsync() metodu, yanıtın içeriğini bir string olarak okur.
                var values = JsonConvert.DeserializeObject<List<ResultArticleDto>>(jsonData); // Json verisini C# nesnesine dönüştürüyoruz. DeserializeObject<T>() metodu, belirtilen JSON dizesini T türünde bir nesneye dönüştürür.
                return View(values);
                //Serialize - Deserialize
                //metin-->json //json-->metin
            }
            return View();
        }
    }
}
