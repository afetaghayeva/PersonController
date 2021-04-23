using System.Net.Http;
using System.Threading.Tasks;
using WindowsForm.Extensions;

namespace WindowsForm.Helpers
{
    public static class ServiceHelper
    {
        public  static async Task<T> GetDataAsync<T>(string url) where T : class, new()
        {
            T entity;
            using (HttpClient client = new HttpClient())
            {
                entity = await client.GetAsJsonAsync<T>(url);
            }
            return entity;
        }

        public static async Task<bool> PostDataAsync<T>(string url, T entity)
        {
            using (HttpClient client=new HttpClient())
            {
                return await client.PostAsJsonAsync(url, entity);
            }
        }

        public static async Task<bool> UpdateDataAsync<T>(string url,T entity)
        {
            using (HttpClient client=new HttpClient())
            {
                return await client.PutAsJsonAsync(url, entity);
            }
        }
        public static async Task<bool> DeleteDataAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.DeleteAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
