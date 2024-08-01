using System.Configuration;
using System.Net.Http.Headers;
using ArtifactsMMO.Client.Schema;
using Newtonsoft.Json;

namespace ArtifactsMMO.Client
{
    class ArtifactsClient
    {
        static readonly private HttpClient client = new();

        static ArtifactsClient()
        {
            string baseUrl = ConfigurationManager.AppSettings.Get("BaseUrl") ?? throw new ConfigurationErrorsException("BaseUrl Must Be defined in app.config");
            client.BaseAddress = new Uri(baseUrl);
            string token = ConfigurationManager.AppSettings.Get("Token") ?? throw new ConfigurationErrorsException("Token Must Be defined in app.config");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public static async Task<T> GetAsync<T>(string requestUri)
        {
            Console.WriteLine(requestUri);
            var responseMessage = await client.GetAsync(requestUri);
            string responseString = await responseMessage.Content.ReadAsStringAsync() ?? throw new Exception("Failed to read status response");
            DataResponse<T> response = JsonConvert.DeserializeObject<DataResponse<T>>(responseString) ?? throw new Exception("Failed to Parse JSON");
            if (response.error != null)
            {
                throw new HttpRequestException($"Error Code {response.error.code}: {response.error.message}");
            }

            return response.data ?? throw new HttpRequestException("No data was returned, or we were unable to parse it successfully");

        }

        public static async Task<T> PostAsync<T>(string requestUri, HttpContent? content)
        {
            Console.WriteLine(requestUri);
            var responseMessage = await client.PostAsync(requestUri, content);
            string responseString = await responseMessage.Content.ReadAsStringAsync() ?? throw new Exception("Failed to read status response");
            DataResponse<T> response = JsonConvert.DeserializeObject<DataResponse<T>>(responseString) ?? throw new Exception("Failed to Parse JSON");

            if (response.error != null)
            {
                throw new HttpRequestException($"Error Code {response.error.code}: {response.error.message}");
            }

            return response.data ?? throw new HttpRequestException("No data was returned, or we were unable to parse it successfully");
        }
    }
}

