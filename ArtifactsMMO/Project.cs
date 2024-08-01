

using ArtifactsMMO.Client.API;

var status = await MyCharacters.Action.Move("TWM", 1, 1);
Console.WriteLine(status);