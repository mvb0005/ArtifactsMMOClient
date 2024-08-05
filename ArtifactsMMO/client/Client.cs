using System.Configuration;
using System.Net.Http.Headers;
using ArtifactsMMO.Client.Schema;
using Newtonsoft.Json;


namespace ArtifactsMMO.Client
{
    static class ArtifactsClient
    {
        static readonly private HttpClient client = new();

        static private readonly Dictionary<string, Cooldown?> lastRequestCooldown = new();

        static ArtifactsClient()
        {
            string baseUrl = ConfigurationManager.AppSettings.Get("BaseUrl") ?? throw new ConfigurationErrorsException("BaseUrl Must Be defined in app.config");
            client.BaseAddress = new Uri(baseUrl);
            string token = ConfigurationManager.AppSettings.Get("Token") ?? throw new ConfigurationErrorsException("Token Must Be defined in app.config");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        static public async Task<T> GetAsync<T>(string requestUri, string? characterName = null)
        {
            WaitForCooldown(characterName);

            Console.WriteLine(requestUri);
            var responseMessage = await client.GetAsync(requestUri);
            T data = (await ParseResponse<T>(responseMessage)) ?? throw new HttpRequestException("No data was returned, or we were unable to parse it successfully");
            return AddCooldown(characterName, data) ;

        }
        public static async Task<T> PostAsync<T>(string requestUri, HttpContent? content, string? characterName = null)
        {
            WaitForCooldown(characterName);

            Console.WriteLine(requestUri);
            var responseMessage = await client.PostAsync(requestUri, content);
            T data = (await ParseResponse<T>(responseMessage)) ?? throw new HttpRequestException("No data was returned, or we were unable to parse it successfully");
            return AddCooldown(characterName, data);

        }
        static private void WaitForCooldown(string? characterName)
        {
            if (characterName != null)
            {
                Util.WaitForCooldown(lastRequestCooldown.GetValueOrDefault(characterName, defaultValue: null));
            }
        }

        static public T AddCooldown<T>(string? characterName, T data)
        {
            Cooldown? cooldown = (Cooldown?) data?.GetType().GetProperty("cooldown")?.GetValue(data);

            if (characterName != null && cooldown != null)
            {
                lastRequestCooldown[characterName] = cooldown;
            }

            return data;
        }

        private static async Task<T> ParseResponse<T>(HttpResponseMessage responseMessage)
        {
            string responseString = await responseMessage.Content.ReadAsStringAsync() ?? throw new Exception("Failed to read status response");
            DataResponse<T> response = JsonConvert.DeserializeObject<DataResponse<T>>(responseString) ?? throw new Exception("Failed to Parse JSON");
            if (response.error != null)
            {
                throw new HttpRequestException($"Error Code {response.error.code}: {response.error.message}");
            }
            var data = response.data ?? throw new HttpRequestException("No data was returned, or we were unable to parse it successfully");
            return data;
        }

    }
}

