using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsForm.Extensions
{
    public static class HttpClientExtensions
    {
        public static async Task<T> GetAsJsonAsync<T>(this HttpClient client,string url) where T:class,new()
        {
            using (HttpResponseMessage response = await client.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<T>();
                }
                else
                {
                    return null;
                }
            }
        }
        public static async Task<bool> PostAsJsonAsync<T>(this HttpClient client, string url,T entity)
        {
            var stringEntity = JsonConvert.SerializeObject(entity);
            HttpContent content = new StringContent(stringEntity, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, content);
            return response.StatusCode != HttpStatusCode.BadRequest;
        }
        public static async Task<bool> PutAsJsonAsync<T>(this HttpClient client, string url, T entity)
        {
            var stringEntity = JsonConvert.SerializeObject(entity);
            HttpContent content = new StringContent(stringEntity, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(url, content);
            return response.StatusCode != HttpStatusCode.BadRequest;
        }
    }
}
