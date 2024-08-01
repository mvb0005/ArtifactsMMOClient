

namespace ArtifactsMMO.Client.API
{
    class Status
    {
        public static async Task<Schema.Status> GetStatus()
        {
            return await ArtifactsClient.GetAsync<Schema.Status>("");
        }
    }
}