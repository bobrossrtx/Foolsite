using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FoolsMod.Tiles.Foolsite
{   
    public class FoolsiteOre : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileMergeDirt[Type] = true;

            drop = ModContent.ItemType<Items.Foolsite.FoolsiteOre>();

            AddMapEntry(Microsoft.Xna.Framework.Color.Purple);
        }
    }
}
