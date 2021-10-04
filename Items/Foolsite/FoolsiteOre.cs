using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace FoolsMod.Items.Foolsite
{
    public class FoolsiteOre : ModItem
    {
        public override void SetDefaults()
        {
            // Hitbox Size
            item.width = 12;
            item.height = 12;

            // Stack & Value
            item.maxStack = 999;
            item.value = Item.buyPrice(silver: 1);
            item.rare = ItemRarityID.Blue;
            item.consumable = true;

            // Usage
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTurn = true;
            item.autoReuse = true;

            // Create Tile
            item.createTile = ModContent.TileType<Tiles.Foolsite.FoolsiteOre>();
        }
    }
}
