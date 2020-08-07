using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FgupAPI
{
    public class RemoteCall
    {
        protected virtual string Host { get; set; } = null; //config["apiUrl"]
        
        //logger

        public RemoteCall()
        {
            //_logger = logger;
        }

        protected async Task<T>  GetRequestAsync<T>(string url)
        {
            if (string.IsNullOrEmpty(Host))
                throw new NotImplementedException("host is empty");

            var uri = CreateUrl(url);
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                    using (HttpResponseMessage response = await client.GetAsync(uri))
                    {
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();

                        return JsonConvert.DeserializeObject<T>(responseBody);
                    }
                }
            }
            catch(Exception ex)
            {
                //log ex
                throw ex;
            }
        }

        protected async Task<Tout> PostRequestAsync<Tin,Tout>(Tin content, string url)
        {
            if (string.IsNullOrEmpty(Host))
                throw new NotImplementedException("host is empty");

            var uri = CreateUrl(url);
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                    var serialized = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");

                    using (HttpResponseMessage response = await client.PostAsync(uri, serialized))
                    {
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();

                        return JsonConvert.DeserializeObject<Tout>(responseBody);
                    }
                }
            }
            catch (Exception ex)
            {
                //log ex
                throw ex;
            }
        }

        private Uri CreateUrl(string url) =>
             new Uri(new Uri(Host), url);
        
    }
}
