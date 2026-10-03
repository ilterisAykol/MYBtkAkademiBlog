using Microsoft.AspNetCore.Mvc;
using MYBtkAkademiBlog.WebUI.Dtos.ArticleDtos;
using Newtonsoft.Json;

namespace MYBtkAkademiBlog.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultFeatureComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultFeatureComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            #region Last_Technology_Article
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7040/api/Articles/GetLastTechnologyArticle"); // ayrıca await metodu async metodların çağrılması için kullanılır. Api'den veri çekmek için GetAsync() metodunu kullanıyoruz. Bu metod, belirtilen URL'ye bir GET isteği gönderir ve yanıtı döndürür.
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync(); // Api'den gelen veriyi json formatında alıyoruz. ReadAsStringAsync() metodu, yanıtın içeriğini bir string olarak okur.
                var values = JsonConvert.DeserializeObject<ResultArticleDto>(jsonData); // Json verisini C# nesnesine dönüştürüyoruz. DeserializeObject<T>() metodu, belirtilen JSON dizesini T türünde bir nesneye dönüştürür.
                //Serialize - Deserialize
                //metin-->json //json-->metin
                ViewBag.LastTechnologyArticleTitle = values.Title;
                ViewBag.LastTechnologyArticleFeatureImageUrl = values.FeatureImageUrl;
                ViewBag.LastTechnologyArticleCreatedDate = values.CreatedDate;
            }


            #endregion

            #region Last_Travel_Article

            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:7040/api/Articles/GetLastTravelArticle");
            if (responseMessage2.IsSuccessStatusCode)
            {
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultArticleDto>(jsonData2);
                ViewBag.LastTravelArticleTitle = values2.Title;
                ViewBag.LastTravelArticleFeatureImageUrl = values2.FeatureImageUrl;
                ViewBag.LastTravelArticleCreatedDate = values2.CreatedDate;
            }

            #endregion

            #region Last_Sports_Article

            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:7040/api/Articles/GetLastSportArticle");
            if (responseMessage3.IsSuccessStatusCode)
            {
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultArticleDto>(jsonData3);
                ViewBag.LastSportsArticleTitle = values3.Title;
                ViewBag.LastSportsArticleFeatureImageUrl = values3.FeatureImageUrl;
                ViewBag.LastSportsArticleCreatedDate = values3.CreatedDate;
            }

            #endregion

            return View();
        }
    }
}
