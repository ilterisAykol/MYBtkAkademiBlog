using Microsoft.AspNetCore.Mvc;
using MYBtkAkademiBlog.WebUI.Dtos.ArticleDtos;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MYBtkAkademiBlog.WebUI.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory; // Api consume: Bize sunulan bir Api'nin json verilerini alıp kullanıcıya sunmak için kullanılan bir yöntemdir. Api'yi kullanmak için HttpClient sınıfını kullanırız.

        public ArticleController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult ArticleDetail()
        {
            return View();
        }
        public async Task<IActionResult> ArticleList()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7040/api/Articles"); // ayrıca await metodu async metodların çağrılması için kullanılır. Api'den veri çekmek için GetAsync() metodunu kullanıyoruz. Bu metod, belirtilen URL'ye bir GET isteği gönderir ve yanıtı döndürür.
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

        public async Task<IActionResult> ArticleList2()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7040/api/Articles"); // ayrıca await metodu async metodların çağrılması için kullanılır. Api'den veri çekmek için GetAsync() metodunu kullanıyoruz. Bu metod, belirtilen URL'ye bir GET isteği gönderir ve yanıtı döndürür.
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

        public IActionResult ArticleListByCategory()
        {
            return View();
        }
    }
}
