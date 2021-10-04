using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FoolsMod.Items.Foolsite
{
    public class FoolsiteBar : ModItem
    {
        public override void SetDefaults()
        {
            // Hitbox Size
            item.width = 12;
            item.height = 12;

            // Stack & Value
            item.maxStack = 99;
            item.value = Item.buyPrice(silver: 3, copper: 25);
            item.rare = ItemRarityID.Blue;
            item.consumable = true;

            // Usage
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTurn = true;
            item.autoReuse = true;

            // Create Tile
            item.createTile = ModContent.TileType<Tiles.FoolsBar>();
            item.placeStyle = 0;
        }

        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<FoolsiteOre>(), 4);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
