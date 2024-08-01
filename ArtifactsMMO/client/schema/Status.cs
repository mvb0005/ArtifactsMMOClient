using Newtonsoft.Json;

namespace ArtifactsMMO.Client.Schema
{
    public record Announcement(
        [property: JsonProperty("message")] string message,
        [property: JsonProperty("created_at")] DateTime created_at
    );

    public record Status(
        [property: JsonProperty("status")] string status,
        [property: JsonProperty("version")] string version,
        [property: JsonProperty("characters_online")] int characters_online,
        [property: JsonProperty("announcements")] IReadOnlyList<Announcement> announcements,
        [property: JsonProperty("last_wipe")] string last_wipe,
        [property: JsonProperty("next_wipe")] string next_wipe
    );
}