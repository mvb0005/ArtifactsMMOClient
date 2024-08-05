
using System.Net.Http.Json;
using ArtifactsMMO.Client.Schema;
using ArtifactsMMO.Client.Schema.ActionSchema;

namespace ArtifactsMMO.Client.API
{
    public class MyCharacters
    {

        static readonly string basePath = "my/";
        public static async Task<Character[]> GetCharacterList()
        {
            var response = await ArtifactsClient.GetAsync<MyCharactersResponse>(basePath + "characters");
            return response.data;
        }

        public class Action
        {
            static readonly string basePath = MyCharacters.basePath + "{0}/action/";

            static string GetUri(string name, string path)
            {
                return string.Format(basePath, name) + path;
            }

            public static async Task<Move> Move(string characterName, int x, int y)
            {

                var content = JsonContent.Create(new { x, y });
                return await ArtifactsClient.PostAsync<Move>(GetUri(characterName, "move"), content, characterName);
            }

            public static async Task<Equip> Equip(string characterName, string itemCode, ItemSlot itemSlot)
            {

                var content = JsonContent.Create(new { code=itemCode, slot=itemSlot.ToString() });
                return await ArtifactsClient.PostAsync<Equip>(GetUri(characterName, "equip"), content, characterName);
            }

            public static async Task<Equip> Unequip(string characterName, ItemSlot itemSlot)
            {

                var content = JsonContent.Create(new { slot = itemSlot.ToString() });
                return await ArtifactsClient.PostAsync<Equip>(GetUri(characterName, "unequip"), content, characterName);

            }

            public static async Task<Fight> Fight(string characterName)
            {
                return await ArtifactsClient.PostAsync<Fight>(GetUri(characterName, "fight"), null, characterName);
            }
            
            public static async Task<Gathering> Gathering(string characterName)
            {

                return await ArtifactsClient.PostAsync<Gathering>(GetUri(characterName, "gathering"), null, characterName);
            }

            public static async Task<Crafting> Crafting(string characterName, string itemCode, int quantity)
            {

                var content = JsonContent.Create(new { code=itemCode, quantity });
                return await ArtifactsClient.PostAsync<Crafting>(GetUri(characterName, "crafting"), content, characterName);

            }

        }
    }
}