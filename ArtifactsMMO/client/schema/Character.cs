
using Newtonsoft.Json;

namespace ArtifactsMMO.Client.Schema
{
    public class InventorySlotAttribute : Attribute
    {
    }
    public class InventoryQuantityAttribute : Attribute
    {
    }

    public record Character(
        [property: JsonProperty("name")] string name,
        [property: JsonProperty("skin")] string skin,
        [property: JsonProperty("level")] int level,
        [property: JsonProperty("xp")] int xp,
        [property: JsonProperty("max_xp")] int max_xp,
        [property: JsonProperty("total_xp")] int total_xp,
        [property: JsonProperty("gold")] int gold,
        [property: JsonProperty("speed")] int speed,
        [property: JsonProperty("mining_level")] int mining_level,
        [property: JsonProperty("mining_xp")] int mining_xp,
        [property: JsonProperty("mining_max_xp")] int mining_max_xp,
        [property: JsonProperty("woodcutting_level")] int woodcutting_level,
        [property: JsonProperty("woodcutting_xp")] int woodcutting_xp,
        [property: JsonProperty("woodcutting_max_xp")] int woodcutting_max_xp,
        [property: JsonProperty("fishing_level")] int fishing_level,
        [property: JsonProperty("fishing_xp")] int fishing_xp,
        [property: JsonProperty("fishing_max_xp")] int fishing_max_xp,
        [property: JsonProperty("weaponcrafting_level")] int weaponcrafting_level,
        [property: JsonProperty("weaponcrafting_xp")] int weaponcrafting_xp,
        [property: JsonProperty("weaponcrafting_max_xp")] int weaponcrafting_max_xp,
        [property: JsonProperty("gearcrafting_level")] int gearcrafting_level,
        [property: JsonProperty("gearcrafting_xp")] int gearcrafting_xp,
        [property: JsonProperty("gearcrafting_max_xp")] int gearcrafting_max_xp,
        [property: JsonProperty("jewelrycrafting_level")] int jewelrycrafting_level,
        [property: JsonProperty("jewelrycrafting_xp")] int jewelrycrafting_xp,
        [property: JsonProperty("jewelrycrafting_max_xp")] int jewelrycrafting_max_xp,
        [property: JsonProperty("cooking_level")] int cooking_level,
        [property: JsonProperty("cooking_xp")] int cooking_xp,
        [property: JsonProperty("cooking_max_xp")] int cooking_max_xp,
        [property: JsonProperty("hp")] int hp,
        [property: JsonProperty("haste")] int haste,
        [property: JsonProperty("critical_strike")] int critical_strike,
        [property: JsonProperty("stamina")] int stamina,
        [property: JsonProperty("attack_fire")] int attack_fire,
        [property: JsonProperty("attack_earth")] int attack_earth,
        [property: JsonProperty("attack_water")] int attack_water,
        [property: JsonProperty("attack_air")] int attack_air,
        [property: JsonProperty("dmg_fire")] int dmg_fire,
        [property: JsonProperty("dmg_earth")] int dmg_earth,
        [property: JsonProperty("dmg_water")] int dmg_water,
        [property: JsonProperty("dmg_air")] int dmg_air,
        [property: JsonProperty("res_fire")] int res_fire,
        [property: JsonProperty("res_earth")] int res_earth,
        [property: JsonProperty("res_water")] int res_water,
        [property: JsonProperty("res_air")] int res_air,
        [property: JsonProperty("x")] int x,
        [property: JsonProperty("y")] int y,
        [property: JsonProperty("cooldown")] int cooldown,
        [property: JsonProperty("cooldown_expiration")] DateTime cooldown_expiration,
        [property: JsonProperty("weapon_slot")] string weapon_slot,
        [property: JsonProperty("shield_slot")] string shield_slot,
        [property: JsonProperty("helmet_slot")] string helmet_slot,
        [property: JsonProperty("body_armor_slot")] string body_armor_slot,
        [property: JsonProperty("leg_armor_slot")] string leg_armor_slot,
        [property: JsonProperty("boots_slot")] string boots_slot,
        [property: JsonProperty("ring1_slot")] string ring1_slot,
        [property: JsonProperty("ring2_slot")] string ring2_slot,
        [property: JsonProperty("amulet_slot")] string amulet_slot,
        [property: JsonProperty("artifact1_slot")] string artifact1_slot,
        [property: JsonProperty("artifact2_slot")] string artifact2_slot,
        [property: JsonProperty("artifact3_slot")] string artifact3_slot,
        [property: JsonProperty("consumable1_slot")] string consumable1_slot,
        [property: JsonProperty("consumable1_slot_quantity")] int consumable1_slot_quantity,
        [property: JsonProperty("consumable2_slot")] string consumable2_slot,
        [property: JsonProperty("consumable2_slot_quantity")] int consumable2_slot_quantity,
        [property: JsonProperty("inventory_slot1"), InventorySlot] string inventory_slot1,
        [property: JsonProperty("inventory_slot1_quantity"), InventoryQuantity] int inventory_slot1_quantity,
        [property: JsonProperty("inventory_slot2"), InventorySlot] string inventory_slot2,
        [property: JsonProperty("inventory_slot2_quantity"), InventoryQuantity] int inventory_slot2_quantity,
        [property: JsonProperty("inventory_slot3"), InventorySlot] string inventory_slot3,
        [property: JsonProperty("inventory_slot3_quantity"), InventoryQuantity] int inventory_slot3_quantity,
        [property: JsonProperty("inventory_slot4"), InventorySlot] string inventory_slot4,
        [property: JsonProperty("inventory_slot4_quantity"), InventoryQuantity] int inventory_slot4_quantity,
        [property: JsonProperty("inventory_slot5"), InventorySlot] string inventory_slot5,
        [property: JsonProperty("inventory_slot5_quantity"), InventoryQuantity] int inventory_slot5_quantity,
        [property: JsonProperty("inventory_slot6"), InventorySlot] string inventory_slot6,
        [property: JsonProperty("inventory_slot6_quantity"), InventoryQuantity] int inventory_slot6_quantity,
        [property: JsonProperty("inventory_slot7"), InventorySlot] string inventory_slot7,
        [property: JsonProperty("inventory_slot7_quantity"), InventoryQuantity] int inventory_slot7_quantity,
        [property: JsonProperty("inventory_slot8"), InventorySlot] string inventory_slot8,
        [property: JsonProperty("inventory_slot8_quantity"), InventoryQuantity] int inventory_slot8_quantity,
        [property: JsonProperty("inventory_slot9"), InventorySlot] string inventory_slot9,
        [property: JsonProperty("inventory_slot9_quantity"), InventoryQuantity] int inventory_slot9_quantity,
        [property: JsonProperty("inventory_slot10"), InventorySlot] string inventory_slot10,
        [property: JsonProperty("inventory_slot10_quantity"), InventoryQuantity] int inventory_slot10_quantity,
        [property: JsonProperty("inventory_slot11"), InventorySlot] string inventory_slot11,
        [property: JsonProperty("inventory_slot11_quantity"), InventoryQuantity] int inventory_slot11_quantity,
        [property: JsonProperty("inventory_slot12"), InventorySlot] string inventory_slot12,
        [property: JsonProperty("inventory_slot12_quantity"), InventoryQuantity] int inventory_slot12_quantity,
        [property: JsonProperty("inventory_slot13"), InventorySlot] string inventory_slot13,
        [property: JsonProperty("inventory_slot13_quantity"), InventoryQuantity] int inventory_slot13_quantity,
        [property: JsonProperty("inventory_slot14"), InventorySlot] string inventory_slot14,
        [property: JsonProperty("inventory_slot14_quantity"), InventoryQuantity] int inventory_slot14_quantity,
        [property: JsonProperty("inventory_slot15"), InventorySlot] string inventory_slot15,
        [property: JsonProperty("inventory_slot15_quantity"), InventoryQuantity] int inventory_slot15_quantity,
        [property: JsonProperty("inventory_slot16"), InventorySlot] string inventory_slot16,
        [property: JsonProperty("inventory_slot16_quantity"), InventoryQuantity] int inventory_slot16_quantity,
        [property: JsonProperty("inventory_slot17"), InventorySlot] string inventory_slot17,
        [property: JsonProperty("inventory_slot17_quantity"), InventoryQuantity] int inventory_slot17_quantity,
        [property: JsonProperty("inventory_slot18"), InventorySlot] string inventory_slot18,
        [property: JsonProperty("inventory_slot18_quantity"), InventoryQuantity] int inventory_slot18_quantity,
        [property: JsonProperty("inventory_slot19"), InventorySlot] string inventory_slot19,
        [property: JsonProperty("inventory_slot19_quantity"), InventoryQuantity] int inventory_slot19_quantity,
        [property: JsonProperty("inventory_slot20"), InventorySlot] string inventory_slot20,
        [property: JsonProperty("inventory_slot20_quantity"), InventoryQuantity] int inventory_slot20_quantity,
        [property: JsonProperty("inventory_max_items")] int inventory_max_items,
        [property: JsonProperty("task")] string task,
        [property: JsonProperty("task_type")] string task_type,
        [property: JsonProperty("task_progress")] int task_progress,
        [property: JsonProperty("task_total")] int task_total,
        [property: JsonProperty("account")] string account
    )
    {
        [JsonIgnore]
        public int inventory_quantity => typeof(Character).GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(InventoryQuantityAttribute))).Sum(prop => (int)(prop.GetValue(this) ?? 0));
        [JsonIgnore]
        public IEnumerable<string> inventory => typeof(Character).GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(InventorySlotAttribute))).Select(prop => (string?)prop.GetValue(this)).OfType<string>();
        [JsonIgnore]
        public bool inventory_full => inventory_quantity == inventory_max_items;
    }

    public record MyCharactersResponse( // TODO: This is probably a common paginated response
        [property: JsonProperty("data")] Character[] data,
        [property: JsonProperty("total")] int total,
        [property: JsonProperty("page")] int page,
        [property: JsonProperty("size")] int size,
        [property: JsonProperty("pages")] int pages
    );


    namespace ActionSchema
    {

        public record Move(
            [property: JsonProperty("cooldown")] Cooldown cooldown,
            [property: JsonProperty("destination")] Destination destination,
            [property: JsonProperty("character")] Character character
        );

        public record Equip(
            [property: JsonProperty("cooldown")] Cooldown cooldown,
            [property: JsonProperty("slot")] string slot,
            [property: JsonProperty("item")] Item item,
            [property: JsonProperty("character")] Character character
        );

        public record Fight(
            [property: JsonProperty("cooldown")] Cooldown cooldown,
            [property: JsonProperty("fight")] FightSchema fight,
            [property: JsonProperty("character")] Character character
        );

        public record Gathering(
            [property: JsonProperty("cooldown")] Cooldown cooldown,
            [property: JsonProperty("details")] Details details,
            [property: JsonProperty("character")] Character character
        );

        public record Crafting(
            [property: JsonProperty("cooldown")] Cooldown cooldown,
            [property: JsonProperty("details")] Details details,
            [property: JsonProperty("character")] Character character
        );

    }

    public record Drop(
        [property: JsonProperty("code")] string code,
        [property: JsonProperty("quantity")] int quantity
    );

    public record MonsterBlockedHits(
        [property: JsonProperty("fire")] int fire,
        [property: JsonProperty("earth")] int earth,
        [property: JsonProperty("water")] int water,
        [property: JsonProperty("air")] int air,
        [property: JsonProperty("total")] int total
    );

    public record PlayerBlockedHits(
        [property: JsonProperty("fire")] int fire,
        [property: JsonProperty("earth")] int earth,
        [property: JsonProperty("water")] int water,
        [property: JsonProperty("air")] int air,
        [property: JsonProperty("total")] int total
    );


    public enum ItemSlot
    {
        weapon,
        shield,
        helmet,
        body_armor,
        leg_armor,
        boots,
        ring1,
        ring2,
        amulet,
        artifact1,
        artifact2,
        artifact3,
        consumable1,
        consumable2
    }

    public record Destination(
        [property: JsonProperty("name")] string name,
        [property: JsonProperty("x")] int x,
        [property: JsonProperty("y")] int y,
        [property: JsonProperty("content")] Content content
    );

    public record FightSchema(
        [property: JsonProperty("xp")] int xp,
        [property: JsonProperty("gold")] int gold,
        [property: JsonProperty("drops")] IReadOnlyList<Drop> drops,
        [property: JsonProperty("turns")] int turns,
        [property: JsonProperty("monster_blocked_hits")] MonsterBlockedHits monster_blocked_hits,
        [property: JsonProperty("player_blocked_hits")] PlayerBlockedHits player_blocked_hits,
        [property: JsonProperty("logs")] IReadOnlyList<string> logs,
        [property: JsonProperty("result")] string result
    );

    public record Craft(
        [property: JsonProperty("skill")] string skill,
        [property: JsonProperty("level")] int level,
        [property: JsonProperty("items")] IReadOnlyList<object> items,
        [property: JsonProperty("quantity"), InventoryQuantity] int quantity
    );

    public record Item(
        [property: JsonProperty("name")] string name,
        [property: JsonProperty("code")] string code,
        [property: JsonProperty("level")] int level,
        [property: JsonProperty("type")] string type,
        [property: JsonProperty("subtype")] string subtype,
        [property: JsonProperty("description")] string description,
        [property: JsonProperty("effects")] IReadOnlyList<object> effects,
        [property: JsonProperty("craft")] Craft craft
    );

    public record Details(
        [property: JsonProperty("xp")] int xp,
        [property: JsonProperty("items")] IReadOnlyList<ItemDetail> items
    );

    public record ItemDetail(
        [property: JsonProperty("code")] string code,
        [property: JsonProperty("quantity")] int quantity
    );





}