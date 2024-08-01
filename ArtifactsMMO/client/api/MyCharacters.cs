
using System.Net;
using System.Net.Http.Json;
using ArtifactsMMO.Client.Schema.ActionSchema;
using Newtonsoft.Json;

namespace ArtifactsMMO.Client.API
{
    class MyCharacters
    {

        static readonly string basePath = "my/";
        public static async Task<Schema.Character[]> GetCharacterList()
        {
            var response = await ArtifactsClient.GetAsync<Schema.MyCharactersResponse>(basePath + "characters");
            return response.data;
        }

        public class Action
        {
            static readonly string basePath = MyCharacters.basePath + "{0}/action/";

            static string getUri(string name, string path)
            {
                return string.Format(basePath, name) + path;
            }

            public static async Task<Move> Move(string characterName, int x, int y)
            {

                var content = JsonContent.Create(new { x, y });
                var response = await ArtifactsClient.PostAsync<Move>(getUri(characterName, "move"), content);

                return response;

            }



        }
    }
}