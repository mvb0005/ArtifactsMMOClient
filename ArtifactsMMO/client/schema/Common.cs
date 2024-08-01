

using Newtonsoft.Json;


namespace ArtifactsMMO.Client.Schema
{
    public record Content(
            [property: JsonProperty("type")] string type,
            [property: JsonProperty("code")] string code
        );

    public record Cooldown(
        [property: JsonProperty("totalSeconds")] int totalSeconds,
        [property: JsonProperty("remainingSeconds")] int remainingSeconds,
        [property: JsonProperty("expiration")] DateTime expiration,
        [property: JsonProperty("reason")] string reason
    );


    public record Error(
        [property: JsonProperty("code")] int code,
        [property: JsonProperty("message")] string message
    );


    public record DataResponse<T>(
        [property: JsonProperty("data")] T? data,
        [property: JsonProperty("error")] Error? error
    );


}